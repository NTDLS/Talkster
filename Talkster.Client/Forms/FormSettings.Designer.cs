using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talkster.Client.Forms
{
    public partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSettings));
            buttonSave = new PoisonButton();
            buttonCancel = new PoisonButton();
            textBoxFontSample = new PoisonTextBox();
            labelFontAndSize = new PoisonLabel();
            comboBoxFont = new PoisonComboBox();
            checkBoxFlashWindowWhenMessageReceived = new PoisonCheckBox();
            checkBoxPlaySoundWhenMessageReceived = new PoisonCheckBox();
            checkBoxPlaySoundWhenContactComesOnline = new PoisonCheckBox();
            textBoxAutoAwayIdleMinutes = new PoisonTextBox();
            checkBoxAlertToastWhenMessageReceived = new PoisonCheckBox();
            labelAutoAwayIdleSeconds = new PoisonLabel();
            checkBoxAlertToastWhenContactComesOnline = new PoisonCheckBox();
            labelServerPort = new PoisonLabel();
            labelServerAddress = new PoisonLabel();
            textBoxServerPort = new PoisonTextBox();
            textBoxServerAddress = new PoisonTextBox();
            checkBoxAutoStartAtWindowsLogin = new PoisonCheckBox();
            textBoxFileTransferChunkSize = new PoisonTextBox();
            textBoxMaxMessages = new PoisonTextBox();
            labelFileTransferChunkSize = new PoisonLabel();
            labelMaxMessages = new PoisonLabel();
            labelRsaKeySize = new PoisonLabel();
            textBoxEndToEndKeySize = new PoisonTextBox();
            textBoxAesKeySize = new PoisonTextBox();
            labelEndToEndKeySize = new PoisonLabel();
            labelAesKeySize = new PoisonLabel();
            textBoxRsaKeySize = new PoisonTextBox();
            textBoxToastTimeoutSeconds = new PoisonTextBox();
            labelToastTimeoutSeconds = new PoisonLabel();
            checkBoxAlertToastErrorMessages = new PoisonCheckBox();
            checkBoxAlertToastWhenMyOnlineStatusChanges = new PoisonCheckBox();
            poisonTabControl1 = new PoisonTabControl();
            tabPage1 = new PoisonTabPage();
            tabPage2 = new PoisonTabPage();
            poisonComboBoxFontSize = new PoisonComboBox();
            tabPage3 = new PoisonTabPage();
            poisonPanel1 = new PoisonPanel();
            poisonLabelTheme = new PoisonLabel();
            poisonRadioButtonDark = new PoisonRadioButton();
            poisonRadioButtonLight = new PoisonRadioButton();
            tabPage4 = new PoisonTabPage();
            tabPage5 = new PoisonTabPage();
            tabPage6 = new PoisonTabPage();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            poisonPanel1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(352, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseSelectable = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(433, 402);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxFontSample
            // 
            // 
            // 
            // 
            textBoxFontSample.CustomButton.Image = null;
            textBoxFontSample.CustomButton.Location = new Point(220, 1);
            textBoxFontSample.CustomButton.Name = "";
            textBoxFontSample.CustomButton.Size = new Size(203, 203);
            textBoxFontSample.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxFontSample.CustomButton.TabIndex = 1;
            textBoxFontSample.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxFontSample.CustomButton.UseSelectable = true;
            textBoxFontSample.CustomButton.Visible = false;
            textBoxFontSample.Location = new Point(0, 68);
            textBoxFontSample.MaxLength = 32767;
            textBoxFontSample.Multiline = true;
            textBoxFontSample.Name = "textBoxFontSample";
            textBoxFontSample.PasswordChar = '\0';
            textBoxFontSample.ScrollBars = ScrollBars.None;
            textBoxFontSample.SelectedText = "";
            textBoxFontSample.SelectionLength = 0;
            textBoxFontSample.SelectionStart = 0;
            textBoxFontSample.ShortcutsEnabled = true;
            textBoxFontSample.Size = new Size(424, 205);
            textBoxFontSample.TabIndex = 2;
            textBoxFontSample.UseSelectable = true;
            textBoxFontSample.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxFontSample.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelFontAndSize
            // 
            labelFontAndSize.AutoSize = true;
            labelFontAndSize.Location = new Point(-4, 10);
            labelFontAndSize.Name = "labelFontAndSize";
            labelFontAndSize.Size = new Size(88, 19);
            labelFontAndSize.TabIndex = 3;
            labelFontAndSize.Text = "Font and Size";
            // 
            // comboBoxFont
            // 
            comboBoxFont.DropDownWidth = 351;
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.ItemHeight = 23;
            comboBoxFont.Location = new Point(0, 33);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(356, 29);
            comboBoxFont.TabIndex = 0;
            comboBoxFont.UseSelectable = true;
            // 
            // checkBoxFlashWindowWhenMessageReceived
            // 
            checkBoxFlashWindowWhenMessageReceived.Location = new Point(6, 58);
            checkBoxFlashWindowWhenMessageReceived.Name = "checkBoxFlashWindowWhenMessageReceived";
            checkBoxFlashWindowWhenMessageReceived.Size = new Size(241, 20);
            checkBoxFlashWindowWhenMessageReceived.TabIndex = 0;
            checkBoxFlashWindowWhenMessageReceived.Text = "Flash window when message is received";
            checkBoxFlashWindowWhenMessageReceived.UseSelectable = true;
            // 
            // checkBoxPlaySoundWhenMessageReceived
            // 
            checkBoxPlaySoundWhenMessageReceived.Location = new Point(6, 32);
            checkBoxPlaySoundWhenMessageReceived.Name = "checkBoxPlaySoundWhenMessageReceived";
            checkBoxPlaySoundWhenMessageReceived.Size = new Size(226, 20);
            checkBoxPlaySoundWhenMessageReceived.TabIndex = 2;
            checkBoxPlaySoundWhenMessageReceived.Text = "Audible alert when message received";
            checkBoxPlaySoundWhenMessageReceived.UseSelectable = true;
            // 
            // checkBoxPlaySoundWhenContactComesOnline
            // 
            checkBoxPlaySoundWhenContactComesOnline.AutoSize = true;
            checkBoxPlaySoundWhenContactComesOnline.Location = new Point(6, 6);
            checkBoxPlaySoundWhenContactComesOnline.Name = "checkBoxPlaySoundWhenContactComesOnline";
            checkBoxPlaySoundWhenContactComesOnline.Size = new Size(239, 15);
            checkBoxPlaySoundWhenContactComesOnline.TabIndex = 1;
            checkBoxPlaySoundWhenContactComesOnline.Text = "Audible alert when contact comes online";
            checkBoxPlaySoundWhenContactComesOnline.UseSelectable = true;
            // 
            // textBoxAutoAwayIdleMinutes
            // 
            // 
            // 
            // 
            textBoxAutoAwayIdleMinutes.CustomButton.Image = null;
            textBoxAutoAwayIdleMinutes.CustomButton.Location = new Point(78, 1);
            textBoxAutoAwayIdleMinutes.CustomButton.Name = "";
            textBoxAutoAwayIdleMinutes.CustomButton.Size = new Size(21, 21);
            textBoxAutoAwayIdleMinutes.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxAutoAwayIdleMinutes.CustomButton.TabIndex = 1;
            textBoxAutoAwayIdleMinutes.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxAutoAwayIdleMinutes.CustomButton.UseSelectable = true;
            textBoxAutoAwayIdleMinutes.CustomButton.Visible = false;
            textBoxAutoAwayIdleMinutes.Location = new Point(279, 81);
            textBoxAutoAwayIdleMinutes.MaxLength = 32767;
            textBoxAutoAwayIdleMinutes.Name = "textBoxAutoAwayIdleMinutes";
            textBoxAutoAwayIdleMinutes.PasswordChar = '\0';
            textBoxAutoAwayIdleMinutes.ScrollBars = ScrollBars.None;
            textBoxAutoAwayIdleMinutes.SelectedText = "";
            textBoxAutoAwayIdleMinutes.SelectionLength = 0;
            textBoxAutoAwayIdleMinutes.SelectionStart = 0;
            textBoxAutoAwayIdleMinutes.ShortcutsEnabled = true;
            textBoxAutoAwayIdleMinutes.Size = new Size(100, 23);
            textBoxAutoAwayIdleMinutes.TabIndex = 8;
            textBoxAutoAwayIdleMinutes.UseSelectable = true;
            textBoxAutoAwayIdleMinutes.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxAutoAwayIdleMinutes.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // checkBoxAlertToastWhenMessageReceived
            // 
            checkBoxAlertToastWhenMessageReceived.Location = new Point(6, 136);
            checkBoxAlertToastWhenMessageReceived.Name = "checkBoxAlertToastWhenMessageReceived";
            checkBoxAlertToastWhenMessageReceived.Size = new Size(228, 20);
            checkBoxAlertToastWhenMessageReceived.TabIndex = 5;
            checkBoxAlertToastWhenMessageReceived.Text = "Visual alert when message is received";
            checkBoxAlertToastWhenMessageReceived.UseSelectable = true;
            // 
            // labelAutoAwayIdleSeconds
            // 
            labelAutoAwayIdleSeconds.AutoSize = true;
            labelAutoAwayIdleSeconds.Location = new Point(275, 55);
            labelAutoAwayIdleSeconds.Name = "labelAutoAwayIdleSeconds";
            labelAutoAwayIdleSeconds.Size = new Size(160, 19);
            labelAutoAwayIdleSeconds.TabIndex = 7;
            labelAutoAwayIdleSeconds.Text = "Auto-away after (minutes)";
            // 
            // checkBoxAlertToastWhenContactComesOnline
            // 
            checkBoxAlertToastWhenContactComesOnline.Location = new Point(6, 110);
            checkBoxAlertToastWhenContactComesOnline.Name = "checkBoxAlertToastWhenContactComesOnline";
            checkBoxAlertToastWhenContactComesOnline.Size = new Size(236, 20);
            checkBoxAlertToastWhenContactComesOnline.TabIndex = 4;
            checkBoxAlertToastWhenContactComesOnline.Text = "Visual alert when contact comes online";
            checkBoxAlertToastWhenContactComesOnline.UseSelectable = true;
            // 
            // labelServerPort
            // 
            labelServerPort.AutoSize = true;
            labelServerPort.Location = new Point(229, 12);
            labelServerPort.Name = "labelServerPort";
            labelServerPort.Size = new Size(76, 19);
            labelServerPort.TabIndex = 3;
            labelServerPort.Text = "Server Port";
            // 
            // labelServerAddress
            // 
            labelServerAddress.AutoSize = true;
            labelServerAddress.Location = new Point(12, 12);
            labelServerAddress.Name = "labelServerAddress";
            labelServerAddress.Size = new Size(98, 19);
            labelServerAddress.TabIndex = 2;
            labelServerAddress.Text = "Server Address";
            // 
            // textBoxServerPort
            // 
            // 
            // 
            // 
            textBoxServerPort.CustomButton.Image = null;
            textBoxServerPort.CustomButton.Location = new Point(58, 1);
            textBoxServerPort.CustomButton.Name = "";
            textBoxServerPort.CustomButton.Size = new Size(21, 21);
            textBoxServerPort.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxServerPort.CustomButton.TabIndex = 1;
            textBoxServerPort.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxServerPort.CustomButton.UseSelectable = true;
            textBoxServerPort.CustomButton.Visible = false;
            textBoxServerPort.Location = new Point(233, 34);
            textBoxServerPort.MaxLength = 32767;
            textBoxServerPort.Name = "textBoxServerPort";
            textBoxServerPort.PasswordChar = '\0';
            textBoxServerPort.ScrollBars = ScrollBars.None;
            textBoxServerPort.SelectedText = "";
            textBoxServerPort.SelectionLength = 0;
            textBoxServerPort.SelectionStart = 0;
            textBoxServerPort.ShortcutsEnabled = true;
            textBoxServerPort.Size = new Size(80, 23);
            textBoxServerPort.TabIndex = 1;
            textBoxServerPort.UseSelectable = true;
            textBoxServerPort.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxServerPort.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxServerAddress
            // 
            // 
            // 
            // 
            textBoxServerAddress.CustomButton.Image = null;
            textBoxServerAddress.CustomButton.Location = new Point(189, 1);
            textBoxServerAddress.CustomButton.Name = "";
            textBoxServerAddress.CustomButton.Size = new Size(21, 21);
            textBoxServerAddress.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxServerAddress.CustomButton.TabIndex = 1;
            textBoxServerAddress.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxServerAddress.CustomButton.UseSelectable = true;
            textBoxServerAddress.CustomButton.Visible = false;
            textBoxServerAddress.Location = new Point(16, 34);
            textBoxServerAddress.MaxLength = 32767;
            textBoxServerAddress.Name = "textBoxServerAddress";
            textBoxServerAddress.PasswordChar = '\0';
            textBoxServerAddress.ScrollBars = ScrollBars.None;
            textBoxServerAddress.SelectedText = "";
            textBoxServerAddress.SelectionLength = 0;
            textBoxServerAddress.SelectionStart = 0;
            textBoxServerAddress.ShortcutsEnabled = true;
            textBoxServerAddress.Size = new Size(211, 23);
            textBoxServerAddress.TabIndex = 0;
            textBoxServerAddress.UseSelectable = true;
            textBoxServerAddress.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxServerAddress.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // checkBoxAutoStartAtWindowsLogin
            // 
            checkBoxAutoStartAtWindowsLogin.AutoSize = true;
            checkBoxAutoStartAtWindowsLogin.Location = new Point(0, 89);
            checkBoxAutoStartAtWindowsLogin.Name = "checkBoxAutoStartAtWindowsLogin";
            checkBoxAutoStartAtWindowsLogin.Size = new Size(175, 15);
            checkBoxAutoStartAtWindowsLogin.TabIndex = 2;
            checkBoxAutoStartAtWindowsLogin.Text = "Auto-start at windows login?";
            checkBoxAutoStartAtWindowsLogin.UseSelectable = true;
            // 
            // textBoxFileTransferChunkSize
            // 
            // 
            // 
            // 
            textBoxFileTransferChunkSize.CustomButton.Image = null;
            textBoxFileTransferChunkSize.CustomButton.Location = new Point(95, 1);
            textBoxFileTransferChunkSize.CustomButton.Name = "";
            textBoxFileTransferChunkSize.CustomButton.Size = new Size(21, 21);
            textBoxFileTransferChunkSize.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxFileTransferChunkSize.CustomButton.TabIndex = 1;
            textBoxFileTransferChunkSize.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxFileTransferChunkSize.CustomButton.UseSelectable = true;
            textBoxFileTransferChunkSize.CustomButton.Visible = false;
            textBoxFileTransferChunkSize.Location = new Point(7, 82);
            textBoxFileTransferChunkSize.MaxLength = 32767;
            textBoxFileTransferChunkSize.Name = "textBoxFileTransferChunkSize";
            textBoxFileTransferChunkSize.PasswordChar = '\0';
            textBoxFileTransferChunkSize.ScrollBars = ScrollBars.None;
            textBoxFileTransferChunkSize.SelectedText = "";
            textBoxFileTransferChunkSize.SelectionLength = 0;
            textBoxFileTransferChunkSize.SelectionStart = 0;
            textBoxFileTransferChunkSize.ShortcutsEnabled = true;
            textBoxFileTransferChunkSize.Size = new Size(117, 23);
            textBoxFileTransferChunkSize.TabIndex = 3;
            textBoxFileTransferChunkSize.UseSelectable = true;
            textBoxFileTransferChunkSize.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxFileTransferChunkSize.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxMaxMessages
            // 
            // 
            // 
            // 
            textBoxMaxMessages.CustomButton.Image = null;
            textBoxMaxMessages.CustomButton.Location = new Point(95, 1);
            textBoxMaxMessages.CustomButton.Name = "";
            textBoxMaxMessages.CustomButton.Size = new Size(21, 21);
            textBoxMaxMessages.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxMaxMessages.CustomButton.TabIndex = 1;
            textBoxMaxMessages.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxMaxMessages.CustomButton.UseSelectable = true;
            textBoxMaxMessages.CustomButton.Visible = false;
            textBoxMaxMessages.Location = new Point(7, 33);
            textBoxMaxMessages.MaxLength = 32767;
            textBoxMaxMessages.Name = "textBoxMaxMessages";
            textBoxMaxMessages.PasswordChar = '\0';
            textBoxMaxMessages.ScrollBars = ScrollBars.None;
            textBoxMaxMessages.SelectedText = "";
            textBoxMaxMessages.SelectionLength = 0;
            textBoxMaxMessages.SelectionStart = 0;
            textBoxMaxMessages.ShortcutsEnabled = true;
            textBoxMaxMessages.Size = new Size(117, 23);
            textBoxMaxMessages.TabIndex = 1;
            textBoxMaxMessages.UseSelectable = true;
            textBoxMaxMessages.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxMaxMessages.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelFileTransferChunkSize
            // 
            labelFileTransferChunkSize.AutoSize = true;
            labelFileTransferChunkSize.Location = new Point(7, 59);
            labelFileTransferChunkSize.Name = "labelFileTransferChunkSize";
            labelFileTransferChunkSize.Size = new Size(96, 19);
            labelFileTransferChunkSize.TabIndex = 2;
            labelFileTransferChunkSize.Text = "File Chunk Size";
            // 
            // labelMaxMessages
            // 
            labelMaxMessages.AutoSize = true;
            labelMaxMessages.Location = new Point(7, 10);
            labelMaxMessages.Name = "labelMaxMessages";
            labelMaxMessages.Size = new Size(94, 19);
            labelMaxMessages.TabIndex = 0;
            labelMaxMessages.Text = "Max Messages";
            // 
            // labelRsaKeySize
            // 
            labelRsaKeySize.AutoSize = true;
            labelRsaKeySize.Location = new Point(7, 10);
            labelRsaKeySize.Name = "labelRsaKeySize";
            labelRsaKeySize.Size = new Size(81, 19);
            labelRsaKeySize.TabIndex = 0;
            labelRsaKeySize.Text = "RSA Key Bits";
            // 
            // textBoxEndToEndKeySize
            // 
            // 
            // 
            // 
            textBoxEndToEndKeySize.CustomButton.Image = null;
            textBoxEndToEndKeySize.CustomButton.Location = new Point(100, 1);
            textBoxEndToEndKeySize.CustomButton.Name = "";
            textBoxEndToEndKeySize.CustomButton.Size = new Size(21, 21);
            textBoxEndToEndKeySize.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxEndToEndKeySize.CustomButton.TabIndex = 1;
            textBoxEndToEndKeySize.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxEndToEndKeySize.CustomButton.UseSelectable = true;
            textBoxEndToEndKeySize.CustomButton.Visible = false;
            textBoxEndToEndKeySize.Location = new Point(7, 131);
            textBoxEndToEndKeySize.MaxLength = 32767;
            textBoxEndToEndKeySize.Name = "textBoxEndToEndKeySize";
            textBoxEndToEndKeySize.PasswordChar = '\0';
            textBoxEndToEndKeySize.ScrollBars = ScrollBars.None;
            textBoxEndToEndKeySize.SelectedText = "";
            textBoxEndToEndKeySize.SelectionLength = 0;
            textBoxEndToEndKeySize.SelectionStart = 0;
            textBoxEndToEndKeySize.ShortcutsEnabled = true;
            textBoxEndToEndKeySize.Size = new Size(122, 23);
            textBoxEndToEndKeySize.TabIndex = 5;
            textBoxEndToEndKeySize.UseSelectable = true;
            textBoxEndToEndKeySize.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxEndToEndKeySize.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxAesKeySize
            // 
            // 
            // 
            // 
            textBoxAesKeySize.CustomButton.Image = null;
            textBoxAesKeySize.CustomButton.Location = new Point(100, 1);
            textBoxAesKeySize.CustomButton.Name = "";
            textBoxAesKeySize.CustomButton.Size = new Size(21, 21);
            textBoxAesKeySize.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxAesKeySize.CustomButton.TabIndex = 1;
            textBoxAesKeySize.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxAesKeySize.CustomButton.UseSelectable = true;
            textBoxAesKeySize.CustomButton.Visible = false;
            textBoxAesKeySize.Location = new Point(7, 82);
            textBoxAesKeySize.MaxLength = 32767;
            textBoxAesKeySize.Name = "textBoxAesKeySize";
            textBoxAesKeySize.PasswordChar = '\0';
            textBoxAesKeySize.ScrollBars = ScrollBars.None;
            textBoxAesKeySize.SelectedText = "";
            textBoxAesKeySize.SelectionLength = 0;
            textBoxAesKeySize.SelectionStart = 0;
            textBoxAesKeySize.ShortcutsEnabled = true;
            textBoxAesKeySize.Size = new Size(122, 23);
            textBoxAesKeySize.TabIndex = 3;
            textBoxAesKeySize.UseSelectable = true;
            textBoxAesKeySize.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxAesKeySize.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelEndToEndKeySize
            // 
            labelEndToEndKeySize.AutoSize = true;
            labelEndToEndKeySize.Location = new Point(7, 108);
            labelEndToEndKeySize.Name = "labelEndToEndKeySize";
            labelEndToEndKeySize.Size = new Size(125, 19);
            labelEndToEndKeySize.TabIndex = 4;
            labelEndToEndKeySize.Text = "End-to-End Key Bits";
            // 
            // labelAesKeySize
            // 
            labelAesKeySize.AutoSize = true;
            labelAesKeySize.Location = new Point(7, 59);
            labelAesKeySize.Name = "labelAesKeySize";
            labelAesKeySize.Size = new Size(80, 19);
            labelAesKeySize.TabIndex = 2;
            labelAesKeySize.Text = "AES Key Bits";
            // 
            // textBoxRsaKeySize
            // 
            // 
            // 
            // 
            textBoxRsaKeySize.CustomButton.Image = null;
            textBoxRsaKeySize.CustomButton.Location = new Point(100, 1);
            textBoxRsaKeySize.CustomButton.Name = "";
            textBoxRsaKeySize.CustomButton.Size = new Size(21, 21);
            textBoxRsaKeySize.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxRsaKeySize.CustomButton.TabIndex = 1;
            textBoxRsaKeySize.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxRsaKeySize.CustomButton.UseSelectable = true;
            textBoxRsaKeySize.CustomButton.Visible = false;
            textBoxRsaKeySize.Location = new Point(7, 33);
            textBoxRsaKeySize.MaxLength = 32767;
            textBoxRsaKeySize.Name = "textBoxRsaKeySize";
            textBoxRsaKeySize.PasswordChar = '\0';
            textBoxRsaKeySize.ScrollBars = ScrollBars.None;
            textBoxRsaKeySize.SelectedText = "";
            textBoxRsaKeySize.SelectionLength = 0;
            textBoxRsaKeySize.SelectionStart = 0;
            textBoxRsaKeySize.ShortcutsEnabled = true;
            textBoxRsaKeySize.Size = new Size(122, 23);
            textBoxRsaKeySize.TabIndex = 1;
            textBoxRsaKeySize.UseSelectable = true;
            textBoxRsaKeySize.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxRsaKeySize.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxToastTimeoutSeconds
            // 
            // 
            // 
            // 
            textBoxToastTimeoutSeconds.CustomButton.Image = null;
            textBoxToastTimeoutSeconds.CustomButton.Location = new Point(78, 1);
            textBoxToastTimeoutSeconds.CustomButton.Name = "";
            textBoxToastTimeoutSeconds.CustomButton.Size = new Size(21, 21);
            textBoxToastTimeoutSeconds.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxToastTimeoutSeconds.CustomButton.TabIndex = 1;
            textBoxToastTimeoutSeconds.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxToastTimeoutSeconds.CustomButton.UseSelectable = true;
            textBoxToastTimeoutSeconds.CustomButton.Visible = false;
            textBoxToastTimeoutSeconds.Location = new Point(279, 26);
            textBoxToastTimeoutSeconds.MaxLength = 32767;
            textBoxToastTimeoutSeconds.Name = "textBoxToastTimeoutSeconds";
            textBoxToastTimeoutSeconds.PasswordChar = '\0';
            textBoxToastTimeoutSeconds.ScrollBars = ScrollBars.None;
            textBoxToastTimeoutSeconds.SelectedText = "";
            textBoxToastTimeoutSeconds.SelectionLength = 0;
            textBoxToastTimeoutSeconds.SelectionStart = 0;
            textBoxToastTimeoutSeconds.ShortcutsEnabled = true;
            textBoxToastTimeoutSeconds.Size = new Size(100, 23);
            textBoxToastTimeoutSeconds.TabIndex = 7;
            textBoxToastTimeoutSeconds.UseSelectable = true;
            textBoxToastTimeoutSeconds.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxToastTimeoutSeconds.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelToastTimeoutSeconds
            // 
            labelToastTimeoutSeconds.AutoSize = true;
            labelToastTimeoutSeconds.Location = new Point(275, 6);
            labelToastTimeoutSeconds.Name = "labelToastTimeoutSeconds";
            labelToastTimeoutSeconds.Size = new Size(184, 19);
            labelToastTimeoutSeconds.TabIndex = 7;
            labelToastTimeoutSeconds.Text = "Visual alert duration (seconds)";
            // 
            // checkBoxAlertToastErrorMessages
            // 
            checkBoxAlertToastErrorMessages.Location = new Point(6, 84);
            checkBoxAlertToastErrorMessages.Name = "checkBoxAlertToastErrorMessages";
            checkBoxAlertToastErrorMessages.Size = new Size(179, 20);
            checkBoxAlertToastErrorMessages.TabIndex = 3;
            checkBoxAlertToastErrorMessages.Text = "Visual alert on various errors";
            checkBoxAlertToastErrorMessages.UseSelectable = true;
            // 
            // checkBoxAlertToastWhenMyOnlineStatusChanges
            // 
            checkBoxAlertToastWhenMyOnlineStatusChanges.AutoSize = true;
            checkBoxAlertToastWhenMyOnlineStatusChanges.Location = new Point(6, 162);
            checkBoxAlertToastWhenMyOnlineStatusChanges.Name = "checkBoxAlertToastWhenMyOnlineStatusChanges";
            checkBoxAlertToastWhenMyOnlineStatusChanges.Size = new Size(249, 15);
            checkBoxAlertToastWhenMyOnlineStatusChanges.TabIndex = 6;
            checkBoxAlertToastWhenMyOnlineStatusChanges.Text = "Visual alert when my online status changes";
            checkBoxAlertToastWhenMyOnlineStatusChanges.UseSelectable = true;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.Controls.Add(tabPage3);
            poisonTabControl1.Controls.Add(tabPage4);
            poisonTabControl1.Controls.Add(tabPage5);
            poisonTabControl1.Controls.Add(tabPage6);
            poisonTabControl1.Location = new Point(23, 63);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(485, 333);
            poisonTabControl1.TabIndex = 6;
            poisonTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxToastTimeoutSeconds);
            tabPage1.Controls.Add(checkBoxPlaySoundWhenContactComesOnline);
            tabPage1.Controls.Add(labelToastTimeoutSeconds);
            tabPage1.Controls.Add(labelAutoAwayIdleSeconds);
            tabPage1.Controls.Add(checkBoxAlertToastErrorMessages);
            tabPage1.Controls.Add(textBoxAutoAwayIdleMinutes);
            tabPage1.Controls.Add(checkBoxAlertToastWhenMyOnlineStatusChanges);
            tabPage1.Controls.Add(checkBoxAlertToastWhenMessageReceived);
            tabPage1.Controls.Add(checkBoxFlashWindowWhenMessageReceived);
            tabPage1.Controls.Add(checkBoxPlaySoundWhenMessageReceived);
            tabPage1.Controls.Add(checkBoxAlertToastWhenContactComesOnline);
            tabPage1.HorizontalScrollbarBarColor = true;
            tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            tabPage1.HorizontalScrollbarSize = 10;
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(477, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Notifications";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.VerticalScrollbarBarColor = true;
            tabPage1.VerticalScrollbarHighlightOnWheel = false;
            tabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(poisonComboBoxFontSize);
            tabPage2.Controls.Add(textBoxFontSample);
            tabPage2.Controls.Add(labelFontAndSize);
            tabPage2.Controls.Add(comboBoxFont);
            tabPage2.HorizontalScrollbarBarColor = true;
            tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            tabPage2.HorizontalScrollbarSize = 10;
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(477, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Messages";
            tabPage2.VerticalScrollbarBarColor = true;
            tabPage2.VerticalScrollbarHighlightOnWheel = false;
            tabPage2.VerticalScrollbarSize = 10;
            // 
            // poisonComboBoxFontSize
            // 
            poisonComboBoxFontSize.FormattingEnabled = true;
            poisonComboBoxFontSize.ItemHeight = 23;
            poisonComboBoxFontSize.Location = new Point(363, 33);
            poisonComboBoxFontSize.Name = "poisonComboBoxFontSize";
            poisonComboBoxFontSize.Size = new Size(61, 29);
            poisonComboBoxFontSize.TabIndex = 4;
            poisonComboBoxFontSize.UseSelectable = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(poisonPanel1);
            tabPage3.Controls.Add(checkBoxAutoStartAtWindowsLogin);
            tabPage3.HorizontalScrollbarBarColor = true;
            tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            tabPage3.HorizontalScrollbarSize = 10;
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(477, 294);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "UI";
            tabPage3.VerticalScrollbarBarColor = true;
            tabPage3.VerticalScrollbarHighlightOnWheel = false;
            tabPage3.VerticalScrollbarSize = 10;
            // 
            // poisonPanel1
            // 
            poisonPanel1.Controls.Add(poisonLabelTheme);
            poisonPanel1.Controls.Add(poisonRadioButtonDark);
            poisonPanel1.Controls.Add(poisonRadioButtonLight);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(3, 3);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(100, 69);
            poisonPanel1.TabIndex = 5;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // poisonLabelTheme
            // 
            poisonLabelTheme.AutoSize = true;
            poisonLabelTheme.Location = new Point(3, 0);
            poisonLabelTheme.Name = "poisonLabelTheme";
            poisonLabelTheme.Size = new Size(49, 19);
            poisonLabelTheme.TabIndex = 6;
            poisonLabelTheme.Text = "Theme";
            // 
            // poisonRadioButtonDark
            // 
            poisonRadioButtonDark.AutoSize = true;
            poisonRadioButtonDark.Location = new Point(7, 43);
            poisonRadioButtonDark.Name = "poisonRadioButtonDark";
            poisonRadioButtonDark.Size = new Size(47, 15);
            poisonRadioButtonDark.TabIndex = 3;
            poisonRadioButtonDark.Text = "Dark";
            poisonRadioButtonDark.UseSelectable = true;
            poisonRadioButtonDark.CheckedChanged += RadioButtonDark_CheckedChanged;
            // 
            // poisonRadioButtonLight
            // 
            poisonRadioButtonLight.AutoSize = true;
            poisonRadioButtonLight.Location = new Point(7, 22);
            poisonRadioButtonLight.Name = "poisonRadioButtonLight";
            poisonRadioButtonLight.Size = new Size(50, 15);
            poisonRadioButtonLight.TabIndex = 4;
            poisonRadioButtonLight.Text = "Light";
            poisonRadioButtonLight.UseSelectable = true;
            poisonRadioButtonLight.CheckedChanged += RadioButtonLight_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBoxServerAddress);
            tabPage4.Controls.Add(labelServerAddress);
            tabPage4.Controls.Add(textBoxServerPort);
            tabPage4.Controls.Add(labelServerPort);
            tabPage4.HorizontalScrollbarBarColor = true;
            tabPage4.HorizontalScrollbarHighlightOnWheel = false;
            tabPage4.HorizontalScrollbarSize = 10;
            tabPage4.Location = new Point(4, 35);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(477, 294);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Server";
            tabPage4.VerticalScrollbarBarColor = true;
            tabPage4.VerticalScrollbarHighlightOnWheel = false;
            tabPage4.VerticalScrollbarSize = 10;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBoxFileTransferChunkSize);
            tabPage5.Controls.Add(labelMaxMessages);
            tabPage5.Controls.Add(textBoxMaxMessages);
            tabPage5.Controls.Add(labelFileTransferChunkSize);
            tabPage5.HorizontalScrollbarBarColor = true;
            tabPage5.HorizontalScrollbarHighlightOnWheel = false;
            tabPage5.HorizontalScrollbarSize = 10;
            tabPage5.Location = new Point(4, 35);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(477, 294);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Advanced";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.VerticalScrollbarBarColor = true;
            tabPage5.VerticalScrollbarHighlightOnWheel = false;
            tabPage5.VerticalScrollbarSize = 10;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBoxEndToEndKeySize);
            tabPage6.Controls.Add(labelRsaKeySize);
            tabPage6.Controls.Add(textBoxRsaKeySize);
            tabPage6.Controls.Add(labelEndToEndKeySize);
            tabPage6.Controls.Add(textBoxAesKeySize);
            tabPage6.Controls.Add(labelAesKeySize);
            tabPage6.HorizontalScrollbarBarColor = true;
            tabPage6.HorizontalScrollbarHighlightOnWheel = false;
            tabPage6.HorizontalScrollbarSize = 10;
            tabPage6.Location = new Point(4, 35);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(477, 294);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Cryptography";
            tabPage6.VerticalScrollbarBarColor = true;
            tabPage6.VerticalScrollbarHighlightOnWheel = false;
            tabPage6.VerticalScrollbarSize = 10;
            // 
            // FormSettings
            // 
            ClientSize = new Size(534, 449);
            Controls.Add(poisonTabControl1);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(450, 380);
            Name = "FormSettings";
            Resizable = false;
            ShowInTaskbar = false;
            Text = "Talkster : Settings";
            poisonTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            poisonPanel1.ResumeLayout(false);
            poisonPanel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }
        private PoisonButton buttonSave;
        private PoisonButton buttonCancel;
        private PoisonComboBox comboBoxFont;
        private PoisonLabel labelFontAndSize;
        private PoisonTextBox textBoxFontSample;
        private PoisonLabel labelServerPort;
        private PoisonLabel labelServerAddress;
        private PoisonTextBox textBoxServerPort;
        private PoisonTextBox textBoxServerAddress;
        private PoisonTextBox textBoxFileTransferChunkSize;
        private PoisonTextBox textBoxMaxMessages;
        private PoisonTextBox textBoxAutoAwayIdleMinutes;
        private PoisonLabel labelFileTransferChunkSize;
        private PoisonLabel labelMaxMessages;
        private PoisonLabel labelAutoAwayIdleSeconds;
        private PoisonCheckBox checkBoxAutoStartAtWindowsLogin;
        private PoisonCheckBox checkBoxFlashWindowWhenMessageReceived;
        private PoisonCheckBox checkBoxPlaySoundWhenMessageReceived;
        private PoisonCheckBox checkBoxPlaySoundWhenContactComesOnline;
        private PoisonCheckBox checkBoxAlertToastWhenMessageReceived;
        private PoisonCheckBox checkBoxAlertToastWhenContactComesOnline;
        private PoisonLabel labelRsaKeySize;
        private PoisonTextBox textBoxEndToEndKeySize;
        private PoisonTextBox textBoxAesKeySize;
        private PoisonLabel labelEndToEndKeySize;
        private PoisonLabel labelAesKeySize;
        private PoisonTextBox textBoxRsaKeySize;
        private PoisonCheckBox checkBoxAlertToastErrorMessages;
        private PoisonCheckBox checkBoxAlertToastWhenMyOnlineStatusChanges;
        private PoisonTextBox textBoxToastTimeoutSeconds;
        private PoisonLabel labelToastTimeoutSeconds;
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private PoisonTabPage tabPage1;
        private PoisonTabPage tabPage2;
        private PoisonTabPage tabPage3;
        private PoisonTabPage tabPage4;
        private PoisonTabPage tabPage5;
        private PoisonTabPage tabPage6;
        private PoisonRadioButton poisonRadioButtonLight;
        private PoisonRadioButton poisonRadioButtonDark;
        private PoisonLabel poisonLabelTheme;
        private PoisonPanel poisonPanel1;
        private PoisonComboBox poisonComboBoxFontSize;
    }
}
