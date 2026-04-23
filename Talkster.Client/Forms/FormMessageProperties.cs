using ReaLTaiizor.Forms;
using Talkster.Library;

namespace Talkster.Client.Forms
{
    public partial class FormMessageProperties
        : PoisonForm
    {
        private ActiveChat _activeChat;

        internal FormMessageProperties(ActiveChat activeChat)
        {
            InitializeComponent();

            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            _activeChat = activeChat;

            textBoxAccountId.Text = activeChat.AccountId.ToString();
            textBoxDisplayName.Text = activeChat.DisplayName;
            textBoxSessionId.Text = activeChat.SessionId.ToString();
            textBoxPublicRsaKey.Text = Crypto.ComputeSha256Hash(_activeChat.PublicPrivateKeyPair.PublicRsaKey);
            labelPublicRsaKeyLength.Text = $"{(_activeChat.PublicPrivateKeyPair.PublicRsaKey.Length * 8):n0}bits";
            textBoxPrivateRsaKey.Text = Crypto.ComputeSha256Hash(_activeChat.PublicPrivateKeyPair.PrivateRsaKey);
            labelPrivateRsaKeyLength.Text = $"{(_activeChat.PublicPrivateKeyPair.PrivateRsaKey.Length * 8):n0}bits";
            textBoxSharedSecret.Text = Crypto.ComputeSha256Hash(_activeChat.SharedSecret);
            labelSharedSecretLength.Text = $"{(_activeChat.SharedSecret.Length * 8):n0}bits";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}