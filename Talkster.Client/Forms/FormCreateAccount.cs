using NTDLS.ReliableMessaging;
using NTDLS.WinFormsHelpers;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using Talkster.Client.Helpers;
using Talkster.Library;
using Talkster.Library.ReliableMessages;

namespace Talkster.Client.Forms
{
    public partial class FormCreateAccount
        : PoisonForm
    {
        private string _username = string.Empty;

        public FormCreateAccount()
        {
            InitializeComponent();

            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            FormClosing += FormCreateAccount_FormClosing;
            AcceptButton = buttonCreate;
            CancelButton = buttonCancel;
        }

        internal string? CreateAccount()
        {
            if (ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(_username))
            {
                return _username;
            }
            return null;
        }

        private void FormCreateAccount_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(_username))
            {
                if (MessageBox.Show("Are you sure you want to cancel.",
                    ScConstants.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.InvokeClose(DialogResult.Cancel);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsername.GetAndValidateText("A username is required.");
                var displayName = textBoxDisplayName.GetAndValidateText("A display name is required.");
                var password = textBoxPassword.GetAndValidateText("A password is required.");
                var confirmPassword = textBoxPassword.GetAndValidateText("A confirm password is required.");

                if (!Crypto.IsPasswordComplex(password, out var errorMessage))
                {
                    throw new Exception(errorMessage);
                }

                if (password != confirmPassword)
                {
                    throw new Exception("Passwords do not match.");
                }

                var passwordHash = Crypto.ComputeSha256Hash(password);
                using var progressForm = new ThemedProgressForm(ScConstants.AppName, "Please wait...");

                progressForm.Execute(() =>
                {
                    try
                    {
                        progressForm.SetHeaderText("Negotiating cryptography...");

                        var connection = ConnectionHelpers.CreateEncryptedConnection(RmExceptionHandler, progressForm);

                        try
                        {
                            progressForm.SetHeaderText("Creating account...");

                            var result = connection.Client.Query(new CreateAccountQuery(username, displayName, passwordHash));
                            _username = result.IsSuccess ? username : string.Empty;

                            this.InvokeClose(result.IsSuccess ? DialogResult.OK : DialogResult.Cancel);
                        }
                        finally
                        {
                            connection.Client.Disconnect();
                        }
                    }
                    catch (Exception ex)
                    {
                        progressForm.MessageBox(ex.GetBaseException().Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                });
            }
            catch (Exception ex)
            {
                Program.Log.Error($"Error in {new StackTrace().GetFrame(0)?.GetMethod()?.Name ?? "Unknown"}.", ex);
                MessageBox.Show(ex.Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RmExceptionHandler(RmContext? context, Exception ex, IRmPayload? payload)
        {
            Program.Log.Error($"Error in {new StackTrace().GetFrame(0)?.GetMethod()?.Name ?? "Unknown"}.", ex);
            MessageBox.Show(ex.Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
