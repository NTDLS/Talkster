﻿using System.Security.Cryptography;
using System.Text;

namespace Talkster.Library
{
    public static class Crypto
    {
        public static string ComputeSha256Hash(string input)
            => ComputeSha256Hash(Encoding.UTF8.GetBytes(input));


        public static string ComputeSha256Hash(byte[] inputBytes)
        {
            var stringBuilder = new StringBuilder();

            var hashBytes = SHA256.HashData(inputBytes);
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static PublicPrivateKeyPair GeneratePublicPrivateKeyPair(int rsaKeySize)
        {
            using var rsa = RSA.Create(rsaKeySize);
            return new PublicPrivateKeyPair(rsa.ExportSubjectPublicKeyInfo(), rsa.ExportPkcs8PrivateKey());
        }

        /// <summary>
        /// Encrypts a byte array with AES using a public key and returns array.
        /// </summary>
        public static byte[] AesEncryptBytes(int rsaKeySize, int aesKeySize, byte[] data, byte[] publicKey)
        {
            using RSA rsa = RSA.Create(rsaKeySize);
            rsa.ImportSubjectPublicKeyInfo(publicKey, out _);

            using Aes aes = Aes.Create();
            aes.KeySize = aesKeySize;
            aes.GenerateKey();
            aes.GenerateIV();

            //Encrypt the AES key with the RSA public key.
            byte[] encryptedKey = rsa.Encrypt(aes.Key, RSAEncryptionPadding.OaepSHA256);

            //Use AES to encrypt the data.
            using ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] cipherText = encryptor.TransformFinalBlock(data, 0, data.Length);

            //Return the AES encrypted key length + encrypted AES key + IV (always 16 bytes) + AES encrypted data.
            byte[] result = new byte[4 + encryptedKey.Length + aes.IV.Length + cipherText.Length];
            BitConverter.GetBytes(encryptedKey.Length).CopyTo(result, 0);
            encryptedKey.CopyTo(result, 4);
            aes.IV.CopyTo(result, 4 + encryptedKey.Length);
            cipherText.CopyTo(result, 4 + encryptedKey.Length + aes.IV.Length);

            return result;
        }

        /// <summary>
        /// Decrypts a byte array with AES using a private key and returns a bytes array.
        /// </summary>
        public static byte[] AesDecryptBytes(int rsaKeySize, byte[] encryptedData, byte[] privateKey)
        {
            using RSA rsa = RSA.Create(rsaKeySize);
            rsa.ImportPkcs8PrivateKey(privateKey, out _);

            //Extract the encrypted AES key length.
            int keyLength = BitConverter.ToInt32(encryptedData, 0);

            //Extract the encrypted AES key.
            byte[] encryptedKey = new byte[keyLength];
            Array.Copy(encryptedData, 4, encryptedKey, 0, keyLength);

            //Decrypt the AES key.
            byte[] aesKey = rsa.Decrypt(encryptedKey, RSAEncryptionPadding.OaepSHA256);

            //Extract the AES IV (always 16 bytes).
            int ivOffset = 4 + keyLength;
            byte[] iv = new byte[16];
            Array.Copy(encryptedData, ivOffset, iv, 0, 16);

            //Extract the cypher text.
            int cipherTextOffset = ivOffset + iv.Length;
            byte[] cipherText = new byte[encryptedData.Length - cipherTextOffset];
            Array.Copy(encryptedData, cipherTextOffset, cipherText, 0, cipherText.Length);

            using Aes aes = Aes.Create();
            aes.Key = aesKey;
            aes.IV = iv; // Set IV for decryption

            //Decrypt the cypher text using AES.
            using ICryptoTransform decryptor = aes.CreateDecryptor();
            byte[] decryptedData = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);

            return decryptedData;
        }

        public static bool IsPasswordComplex(string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(password.Trim()))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < ScConstants.MinPasswordLength)
            {
                errorMessage = $"Password must be at least {ScConstants.MinPasswordLength:n0} characters long.";
                return false;
            }

            int metricCount = 0;
            if (password.Any(char.IsUpper)) metricCount++;
            if (password.Any(char.IsLower)) metricCount++;
            if (password.Any(char.IsDigit)) metricCount++;
            if (password.Any(char.IsSymbol)) metricCount++;

            if (metricCount < 2)
            {
                errorMessage = "Password must contain at least two of the following: uppercase letter, lowercase letter, digit, symbol.";
                return false;
            }

            return true;
        }
    }
}
