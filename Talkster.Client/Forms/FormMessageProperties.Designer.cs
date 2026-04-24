using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormMessageProperties
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageProperties));
            labelAccountId = new PoisonLabel();
            textBoxAccountId = new PoisonTextBox();
            labelDisplayName = new PoisonLabel();
            textBoxDisplayName = new PoisonTextBox();
            buttonClose = new PoisonButton();
            textBoxPublicRsaKey = new PoisonTextBox();
            labelPublicRsaKey = new PoisonLabel();
            textBoxSessionId = new PoisonTextBox();
            LebelSessionId = new PoisonLabel();
            textBoxSharedSecret = new PoisonTextBox();
            labelSharedSecret = new PoisonLabel();
            textBoxPrivateRsaKey = new PoisonTextBox();
            labelPrivateRsaKey = new PoisonLabel();
            labelSharedSecretLength = new PoisonLabel();
            labelPrivateRsaKeyLength = new PoisonLabel();
            labelPublicRsaKeyLength = new PoisonLabel();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            SuspendLayout();
            // 
            // labelAccountId
            // 
            labelAccountId.AutoSize = true;
            labelAccountId.Location = new Point(23, 109);
            labelAccountId.Name = "labelAccountId";
            labelAccountId.Size = new Size(71, 19);
            labelAccountId.TabIndex = 0;
            labelAccountId.Text = "Account Id";
            // 
            // textBoxAccountId
            // 
            // 
            // 
            // 
            textBoxAccountId.CustomButton.Image = null;
            textBoxAccountId.CustomButton.Location = new Point(266, 1);
            textBoxAccountId.CustomButton.Name = "";
            textBoxAccountId.CustomButton.Size = new Size(21, 21);
            textBoxAccountId.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxAccountId.CustomButton.TabIndex = 1;
            textBoxAccountId.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxAccountId.CustomButton.UseSelectable = true;
            textBoxAccountId.CustomButton.Visible = false;
            textBoxAccountId.Location = new Point(27, 131);
            textBoxAccountId.MaxLength = 32767;
            textBoxAccountId.Name = "textBoxAccountId";
            textBoxAccountId.PasswordChar = '\0';
            textBoxAccountId.ReadOnly = true;
            textBoxAccountId.ScrollBars = ScrollBars.None;
            textBoxAccountId.SelectedText = "";
            textBoxAccountId.SelectionLength = 0;
            textBoxAccountId.SelectionStart = 0;
            textBoxAccountId.ShortcutsEnabled = true;
            textBoxAccountId.Size = new Size(288, 23);
            textBoxAccountId.TabIndex = 1;
            textBoxAccountId.UseSelectable = true;
            textBoxAccountId.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxAccountId.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelDisplayName
            // 
            labelDisplayName.AutoSize = true;
            labelDisplayName.Location = new Point(23, 60);
            labelDisplayName.Name = "labelDisplayName";
            labelDisplayName.Size = new Size(90, 19);
            labelDisplayName.TabIndex = 2;
            labelDisplayName.Text = "Display Name";
            // 
            // textBoxDisplayName
            // 
            // 
            // 
            // 
            textBoxDisplayName.CustomButton.Image = null;
            textBoxDisplayName.CustomButton.Location = new Point(266, 1);
            textBoxDisplayName.CustomButton.Name = "";
            textBoxDisplayName.CustomButton.Size = new Size(21, 21);
            textBoxDisplayName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxDisplayName.CustomButton.TabIndex = 1;
            textBoxDisplayName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxDisplayName.CustomButton.UseSelectable = true;
            textBoxDisplayName.CustomButton.Visible = false;
            textBoxDisplayName.Location = new Point(27, 82);
            textBoxDisplayName.MaxLength = 32767;
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.PasswordChar = '\0';
            textBoxDisplayName.ReadOnly = true;
            textBoxDisplayName.ScrollBars = ScrollBars.None;
            textBoxDisplayName.SelectedText = "";
            textBoxDisplayName.SelectionLength = 0;
            textBoxDisplayName.SelectionStart = 0;
            textBoxDisplayName.ShortcutsEnabled = true;
            textBoxDisplayName.Size = new Size(288, 23);
            textBoxDisplayName.TabIndex = 0;
            textBoxDisplayName.UseSelectable = true;
            textBoxDisplayName.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxDisplayName.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(240, 356);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.UseSelectable = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxPublicRsaKey
            // 
            // 
            // 
            // 
            textBoxPublicRsaKey.CustomButton.Image = null;
            textBoxPublicRsaKey.CustomButton.Location = new Point(266, 1);
            textBoxPublicRsaKey.CustomButton.Name = "";
            textBoxPublicRsaKey.CustomButton.Size = new Size(21, 21);
            textBoxPublicRsaKey.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPublicRsaKey.CustomButton.TabIndex = 1;
            textBoxPublicRsaKey.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPublicRsaKey.CustomButton.UseSelectable = true;
            textBoxPublicRsaKey.CustomButton.Visible = false;
            textBoxPublicRsaKey.Location = new Point(27, 229);
            textBoxPublicRsaKey.MaxLength = 32767;
            textBoxPublicRsaKey.Name = "textBoxPublicRsaKey";
            textBoxPublicRsaKey.PasswordChar = '\0';
            textBoxPublicRsaKey.ReadOnly = true;
            textBoxPublicRsaKey.ScrollBars = ScrollBars.None;
            textBoxPublicRsaKey.SelectedText = "";
            textBoxPublicRsaKey.SelectionLength = 0;
            textBoxPublicRsaKey.SelectionStart = 0;
            textBoxPublicRsaKey.ShortcutsEnabled = true;
            textBoxPublicRsaKey.Size = new Size(288, 23);
            textBoxPublicRsaKey.TabIndex = 3;
            textBoxPublicRsaKey.UseSelectable = true;
            textBoxPublicRsaKey.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPublicRsaKey.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelPublicRsaKey
            // 
            labelPublicRsaKey.AutoSize = true;
            labelPublicRsaKey.Location = new Point(23, 207);
            labelPublicRsaKey.Name = "labelPublicRsaKey";
            labelPublicRsaKey.Size = new Size(106, 19);
            labelPublicRsaKey.TabIndex = 9;
            labelPublicRsaKey.Text = "Public Key (hash)";
            // 
            // textBoxSessionId
            // 
            // 
            // 
            // 
            textBoxSessionId.CustomButton.Image = null;
            textBoxSessionId.CustomButton.Location = new Point(266, 1);
            textBoxSessionId.CustomButton.Name = "";
            textBoxSessionId.CustomButton.Size = new Size(21, 21);
            textBoxSessionId.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxSessionId.CustomButton.TabIndex = 1;
            textBoxSessionId.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxSessionId.CustomButton.UseSelectable = true;
            textBoxSessionId.CustomButton.Visible = false;
            textBoxSessionId.Location = new Point(27, 180);
            textBoxSessionId.MaxLength = 32767;
            textBoxSessionId.Name = "textBoxSessionId";
            textBoxSessionId.PasswordChar = '\0';
            textBoxSessionId.ReadOnly = true;
            textBoxSessionId.ScrollBars = ScrollBars.None;
            textBoxSessionId.SelectedText = "";
            textBoxSessionId.SelectionLength = 0;
            textBoxSessionId.SelectionStart = 0;
            textBoxSessionId.ShortcutsEnabled = true;
            textBoxSessionId.Size = new Size(288, 23);
            textBoxSessionId.TabIndex = 2;
            textBoxSessionId.UseSelectable = true;
            textBoxSessionId.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxSessionId.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // LebelSessionId
            // 
            LebelSessionId.AutoSize = true;
            LebelSessionId.Location = new Point(23, 158);
            LebelSessionId.Name = "LebelSessionId";
            LebelSessionId.Size = new Size(66, 19);
            LebelSessionId.TabIndex = 7;
            LebelSessionId.Text = "Session Id";
            // 
            // textBoxSharedSecret
            // 
            // 
            // 
            // 
            textBoxSharedSecret.CustomButton.Image = null;
            textBoxSharedSecret.CustomButton.Location = new Point(266, 1);
            textBoxSharedSecret.CustomButton.Name = "";
            textBoxSharedSecret.CustomButton.Size = new Size(21, 21);
            textBoxSharedSecret.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxSharedSecret.CustomButton.TabIndex = 1;
            textBoxSharedSecret.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxSharedSecret.CustomButton.UseSelectable = true;
            textBoxSharedSecret.CustomButton.Visible = false;
            textBoxSharedSecret.Location = new Point(27, 327);
            textBoxSharedSecret.MaxLength = 32767;
            textBoxSharedSecret.Name = "textBoxSharedSecret";
            textBoxSharedSecret.PasswordChar = '\0';
            textBoxSharedSecret.ReadOnly = true;
            textBoxSharedSecret.ScrollBars = ScrollBars.None;
            textBoxSharedSecret.SelectedText = "";
            textBoxSharedSecret.SelectionLength = 0;
            textBoxSharedSecret.SelectionStart = 0;
            textBoxSharedSecret.ShortcutsEnabled = true;
            textBoxSharedSecret.Size = new Size(288, 23);
            textBoxSharedSecret.TabIndex = 5;
            textBoxSharedSecret.UseSelectable = true;
            textBoxSharedSecret.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxSharedSecret.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelSharedSecret
            // 
            labelSharedSecret.AutoSize = true;
            labelSharedSecret.Location = new Point(23, 305);
            labelSharedSecret.Name = "labelSharedSecret";
            labelSharedSecret.Size = new Size(128, 19);
            labelSharedSecret.TabIndex = 13;
            labelSharedSecret.Text = "Shared Secret (hash)";
            // 
            // textBoxPrivateRsaKey
            // 
            // 
            // 
            // 
            textBoxPrivateRsaKey.CustomButton.Image = null;
            textBoxPrivateRsaKey.CustomButton.Location = new Point(266, 1);
            textBoxPrivateRsaKey.CustomButton.Name = "";
            textBoxPrivateRsaKey.CustomButton.Size = new Size(21, 21);
            textBoxPrivateRsaKey.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPrivateRsaKey.CustomButton.TabIndex = 1;
            textBoxPrivateRsaKey.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPrivateRsaKey.CustomButton.UseSelectable = true;
            textBoxPrivateRsaKey.CustomButton.Visible = false;
            textBoxPrivateRsaKey.Location = new Point(27, 278);
            textBoxPrivateRsaKey.MaxLength = 32767;
            textBoxPrivateRsaKey.Name = "textBoxPrivateRsaKey";
            textBoxPrivateRsaKey.PasswordChar = '\0';
            textBoxPrivateRsaKey.ReadOnly = true;
            textBoxPrivateRsaKey.ScrollBars = ScrollBars.None;
            textBoxPrivateRsaKey.SelectedText = "";
            textBoxPrivateRsaKey.SelectionLength = 0;
            textBoxPrivateRsaKey.SelectionStart = 0;
            textBoxPrivateRsaKey.ShortcutsEnabled = true;
            textBoxPrivateRsaKey.Size = new Size(288, 23);
            textBoxPrivateRsaKey.TabIndex = 4;
            textBoxPrivateRsaKey.UseSelectable = true;
            textBoxPrivateRsaKey.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPrivateRsaKey.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelPrivateRsaKey
            // 
            labelPrivateRsaKey.AutoSize = true;
            labelPrivateRsaKey.Location = new Point(23, 256);
            labelPrivateRsaKey.Name = "labelPrivateRsaKey";
            labelPrivateRsaKey.Size = new Size(111, 19);
            labelPrivateRsaKey.TabIndex = 11;
            labelPrivateRsaKey.Text = "Private Key (hash)";
            // 
            // labelSharedSecretLength
            // 
            labelSharedSecretLength.AutoSize = true;
            labelSharedSecretLength.Location = new Point(261, 305);
            labelSharedSecretLength.Name = "labelSharedSecretLength";
            labelSharedSecretLength.Size = new Size(50, 19);
            labelSharedSecretLength.TabIndex = 14;
            labelSharedSecretLength.Text = "000bits";
            // 
            // labelPrivateRsaKeyLength
            // 
            labelPrivateRsaKeyLength.AutoSize = true;
            labelPrivateRsaKeyLength.Location = new Point(261, 256);
            labelPrivateRsaKeyLength.Name = "labelPrivateRsaKeyLength";
            labelPrivateRsaKeyLength.Size = new Size(50, 19);
            labelPrivateRsaKeyLength.TabIndex = 15;
            labelPrivateRsaKeyLength.Text = "000bits";
            // 
            // labelPublicRsaKeyLength
            // 
            labelPublicRsaKeyLength.AutoSize = true;
            labelPublicRsaKeyLength.Location = new Point(261, 207);
            labelPublicRsaKeyLength.Name = "labelPublicRsaKeyLength";
            labelPublicRsaKeyLength.Size = new Size(50, 19);
            labelPublicRsaKeyLength.TabIndex = 16;
            labelPublicRsaKeyLength.Text = "000bits";
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // FormMessageProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 402);
            Controls.Add(textBoxSharedSecret);
            Controls.Add(textBoxPrivateRsaKey);
            Controls.Add(textBoxPublicRsaKey);
            Controls.Add(textBoxSessionId);
            Controls.Add(textBoxDisplayName);
            Controls.Add(textBoxAccountId);
            Controls.Add(labelSharedSecret);
            Controls.Add(labelPrivateRsaKey);
            Controls.Add(labelPublicRsaKey);
            Controls.Add(LebelSessionId);
            Controls.Add(buttonClose);
            Controls.Add(labelDisplayName);
            Controls.Add(labelAccountId);
            Controls.Add(labelPublicRsaKeyLength);
            Controls.Add(labelPrivateRsaKeyLength);
            Controls.Add(labelSharedSecretLength);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMessageProperties";
            Resizable = false;
            Text = "Talkster";
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PoisonLabel labelAccountId;
        private PoisonTextBox textBoxAccountId;
        private PoisonLabel labelDisplayName;
        private PoisonTextBox textBoxDisplayName;
        private PoisonButton buttonClose;
        private PoisonTextBox textBoxPublicRsaKey;
        private PoisonLabel labelPublicRsaKey;
        private PoisonTextBox textBoxSessionId;
        private PoisonLabel LebelSessionId;
        private PoisonTextBox textBoxSharedSecret;
        private PoisonLabel labelSharedSecret;
        private PoisonTextBox textBoxPrivateRsaKey;
        private PoisonLabel labelPrivateRsaKey;
        private PoisonLabel labelSharedSecretLength;
        private PoisonLabel labelPrivateRsaKeyLength;
        private PoisonLabel labelPublicRsaKeyLength;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
    }
}