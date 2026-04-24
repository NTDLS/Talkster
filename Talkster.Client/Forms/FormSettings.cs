using NTDLS.Helpers;
using NTDLS.Persistence;
using NTDLS.WinFormsHelpers;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using Talkster.Client.Helpers;
using Talkster.Library;

namespace Talkster.Client.Forms
{
    public partial class FormSettings
        : PoisonForm
    {
        public FormSettings(bool showInTaskbar)
        {
            InitializeComponent();

            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            if (showInTaskbar)
            {
                ShowInTaskbar = true;
                StartPosition = FormStartPosition.CenterScreen;
                TopMost = true;
            }
            else
            {
                ShowInTaskbar = false;
                StartPosition = FormStartPosition.CenterParent;
            }

            AcceptButton = buttonSave;
            CancelButton = buttonCancel;

            Exceptions.Ignore(() => checkBoxAutoStartAtWindowsLogin.Checked = RegistryHelper.IsAutoStartEnabled());

            textBoxToastTimeoutSeconds.Text = $"{Settings.Instance.ToastTimeoutSeconds:n0}";
            textBoxRsaKeySize.Text = $"{Settings.Instance.RsaKeySize:n0}";
            textBoxAesKeySize.Text = $"{Settings.Instance.AesKeySize:n0}";
            textBoxEndToEndKeySize.Text = $"{Settings.Instance.EndToEndKeySize:n0}";
            textBoxServerAddress.Text = Settings.Instance.ServerAddress;
            textBoxServerPort.Text = $"{Settings.Instance.ServerPort:n0}";
            textBoxAutoAwayIdleMinutes.Text = $"{Settings.Instance.AutoAwayIdleMinutes:n0}";
            textBoxMaxMessages.Text = $"{Settings.Instance.MaxMessages:n0}";
            textBoxFileTransferChunkSize.Text = $"{Settings.Instance.FileTransferChunkSize:n0}";
            checkBoxAlertToastWhenContactComesOnline.Checked = Settings.Instance.AlertToastWhenContactComesOnline;
            checkBoxAlertToastWhenMessageReceived.Checked = Settings.Instance.AlertToastWhenMessageReceived;
            checkBoxPlaySoundWhenContactComesOnline.Checked = Settings.Instance.PlaySoundWhenContactComesOnline;
            checkBoxPlaySoundWhenMessageReceived.Checked = Settings.Instance.PlaySoundWhenMessageReceived;
            checkBoxFlashWindowWhenMessageReceived.Checked = Settings.Instance.FlashWindowWhenMessageReceived;
            checkBoxAlertToastWhenMyOnlineStatusChanges.Checked = Settings.Instance.AlertToastWhenMyOnlineStatusChanges;
            checkBoxAlertToastErrorMessages.Checked = Settings.Instance.AlertToastErrorMessages;
            poisonRadioButtonDark.Checked = Settings.Instance.IsthemeDark;
            poisonRadioButtonLight.Checked = !Settings.Instance.IsthemeDark;

            textBoxFontSample.Text = "John: Hey, how's is been going?\r\nJane: Pretty good. I've about to head out.\r\nJohn: Wanna grab some lunch?\r\nJane: Thai?\r\nJohn: Are you kidding me? Absolutely!\r\n";

            foreach (var font in FontFamily.Families.OrderBy(o => o.Name))
            {
                comboBoxFont.Items.Add(font.Name);
            }
            comboBoxFont.Text = Settings.Instance.Font;
            poisonComboBoxFontSize.SelectedValue = Settings.Instance.FontSize;

            poisonComboBoxFontSize.SelectedIndexChanged += (object? sender, EventArgs e) => UpdateFontSample();
            comboBoxFont.SelectedIndexChanged += (object? sender, EventArgs e) => UpdateFontSample();

            UpdateFontSample();
        }

        private void UpdateFontSample()
        {
            var selectedFontName = comboBoxFont.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFontName) == false)
            {
                try
                {
                    var fontSize = poisonComboBoxFontSize.SelectedValue as int?;
                    if (fontSize > 0)
                    {
                        textBoxFontSample.Font = new Font(selectedFontName, (float)fontSize);
                    }
                }
                catch { }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var settings = LocalUserApplicationData.LoadFromDisk(ScConstants.AppName, new Settings());

                settings.IsthemeDark = poisonRadioButtonDark.Checked;
                settings.ServerAddress = textBoxServerAddress.GetAndValidateText("Server address must not be empty.");
                settings.Font = comboBoxFont.Text;
                settings.FontSize = (poisonComboBoxFontSize.SelectedValue as int?) ?? ScConstants.DefaultFontSize;
                settings.ServerPort = textBoxServerPort.GetAndValidateNumeric(1, 65535, "Server port must be between [min] and [max].");
                settings.AutoAwayIdleMinutes = textBoxAutoAwayIdleMinutes.GetAndValidateNumeric(1, 1440, "Auto-away idle minutes must be between [min] and [max].");
                settings.MaxMessages = textBoxMaxMessages.GetAndValidateNumeric(10, 10000, "Max messages must be between [min] and [max].");
                settings.RsaKeySize = textBoxRsaKeySize.GetAndValidateNumeric(1024, 4096, "Max messages must be between [min] and [max].");
                settings.AesKeySize = textBoxAesKeySize.GetAndValidateNumeric(128, 256, "Max messages must be between [min] and [max].");
                settings.EndToEndKeySize = textBoxEndToEndKeySize.GetAndValidateNumeric(128, 10240, "Max messages must be between [min] and [max].");
                settings.FileTransferChunkSize = textBoxFileTransferChunkSize.GetAndValidateNumeric(128, 1024 * 1024, "File transfer chunk size must be between [min] and [max].");
                settings.ToastTimeoutSeconds = textBoxToastTimeoutSeconds.GetAndValidateNumeric(1, 300, "Duration of visual alerts (seconds) must be between [min] and [max].");

                settings.AlertToastWhenContactComesOnline = checkBoxAlertToastWhenContactComesOnline.Checked;
                settings.AlertToastWhenMessageReceived = checkBoxAlertToastWhenMessageReceived.Checked;
                settings.PlaySoundWhenContactComesOnline = checkBoxPlaySoundWhenContactComesOnline.Checked;
                settings.PlaySoundWhenMessageReceived = checkBoxPlaySoundWhenMessageReceived.Checked;
                settings.FlashWindowWhenMessageReceived = checkBoxFlashWindowWhenMessageReceived.Checked;
                settings.AlertToastWhenMyOnlineStatusChanges = checkBoxAlertToastWhenMyOnlineStatusChanges.Checked;
                settings.AlertToastErrorMessages = checkBoxAlertToastErrorMessages.Checked;

                if (ScConstants.AcceptableAesKeySizes.Contains(settings.AesKeySize) == false)
                {
                    throw new ArgumentOutOfRangeException("AES key size must be 128, 192, or 256.");
                }

                if (ScConstants.AcceptableRsaKeySizes.Contains(settings.RsaKeySize) == false)
                {
                    throw new ArgumentOutOfRangeException("RSA key size must be 1024, 2048, 3072, or 4096.");
                }

                try
                {
                    if (checkBoxAutoStartAtWindowsLogin.Checked)
                    {
                        RegistryHelper.EnableAutoStart();
                    }
                    else
                    {
                        RegistryHelper.DisableAutoStart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to set auto-start registry entry. Error: {ex.GetBaseException().Message}", ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Settings.Instance = settings;

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
            try
            {
            }
            catch
            {
            }

            this.InvokeClose(DialogResult.Cancel);
        }
    }
}
