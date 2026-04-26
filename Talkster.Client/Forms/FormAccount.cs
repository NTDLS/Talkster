using NTDLS.WinFormsHelpers;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using Talkster.Library;
using Talkster.Library.ReliableMessages;

namespace Talkster.Client.Forms
{
    public partial class FormAccount
        : PoisonForm
    {
        public FormAccount(bool showInTaskbar)
        {
            InitializeComponent();
            Theming.SetupTheme(this);

            if (ServerConnection.Current?.Connection.Client.IsConnected != true)
            {
                return;
            }

            if (showInTaskbar)
            {
                ShowInTaskbar = true;
                StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                ShowInTaskbar = false;
                StartPosition = FormStartPosition.CenterParent;
            }

            textBoxUsername.Text = ServerConnection.Current.Username;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServerConnection.Current?.Connection.Client.IsConnected != true)
                {
                    MessageBox.Show("Connection to the server was lost.", ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.InvokeClose(DialogResult.Cancel);
                    return;
                }

                var password = textBoxPassword.GetAndValidateText("A password is required.");
                var confirmPassword = textBoxConfirmPassword.GetAndValidateText("A confirm password is required.");

                if (!Crypto.IsPasswordComplex(password, out var errorMessage))
                {
                    throw new Exception(errorMessage);
                }

                if (password != confirmPassword)
                {
                    throw new Exception("Passwords do not match.");
                }

                ServerConnection.Current.Connection.Client.Query(new UpdateAccountPasswordQuery(Crypto.ComputeSha256Hash(password))).ThrowIfFailed();

                this.InvokeClose(DialogResult.OK);
            }
            catch (Exception ex)
            {
                Program.Log.Error($"Error in {new StackTrace().GetFrame(0)?.GetMethod()?.Name ?? "Unknown"}.", ex);
                MessageBox.Show(ex.Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.InvokeClose(DialogResult.Cancel);
        }
    }
}
