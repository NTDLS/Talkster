using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelUsername = new PoisonLabel();
            textBoxUsername = new PoisonTextBox();
            labelPassword = new PoisonLabel();
            textBoxPassword = new PoisonTextBox();
            pictureBoxLogo = new PictureBox();
            buttonLogin = new PoisonButton();
            buttonCancel = new PoisonButton();
            linkLabelCreateAccount = new PoisonLinkLabel();
            checkBoxStayLoggedIn = new PoisonCheckBox();
            buttonSettings = new PoisonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(107, 60);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(68, 19);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            textBoxUsername.CustomButton.Image = null;
            textBoxUsername.CustomButton.Location = new Point(175, 1);
            textBoxUsername.CustomButton.Name = "";
            textBoxUsername.CustomButton.Size = new Size(21, 21);
            textBoxUsername.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxUsername.CustomButton.TabIndex = 1;
            textBoxUsername.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxUsername.CustomButton.UseSelectable = true;
            textBoxUsername.CustomButton.Visible = false;
            textBoxUsername.Location = new Point(111, 82);
            textBoxUsername.MaxLength = 32767;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PasswordChar = '\0';
            textBoxUsername.ScrollBars = ScrollBars.None;
            textBoxUsername.SelectedText = "";
            textBoxUsername.SelectionLength = 0;
            textBoxUsername.SelectionStart = 0;
            textBoxUsername.ShortcutsEnabled = true;
            textBoxUsername.Size = new Size(197, 23);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.UseSelectable = true;
            textBoxUsername.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxUsername.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(107, 108);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(63, 19);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            textBoxPassword.CustomButton.Image = null;
            textBoxPassword.CustomButton.Location = new Point(175, 1);
            textBoxPassword.CustomButton.Name = "";
            textBoxPassword.CustomButton.Size = new Size(21, 21);
            textBoxPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPassword.CustomButton.TabIndex = 1;
            textBoxPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPassword.CustomButton.UseSelectable = true;
            textBoxPassword.CustomButton.Visible = false;
            textBoxPassword.Location = new Point(111, 130);
            textBoxPassword.MaxLength = 32767;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.ScrollBars = ScrollBars.None;
            textBoxPassword.SelectedText = "";
            textBoxPassword.SelectionLength = 0;
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.ShortcutsEnabled = true;
            textBoxPassword.Size = new Size(197, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSelectable = true;
            textBoxPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxLogo.Location = new Point(23, 77);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(73, 70);
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(156, 211);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 25);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseSelectable = true;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(237, 211);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 25);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(107, 180);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(205, 25);
            linkLabelCreateAccount.TabIndex = 3;
            linkLabelCreateAccount.Text = "Don't have an account? Create one!";
            linkLabelCreateAccount.UseSelectable = true;
            linkLabelCreateAccount.Click += LinkLabelCreateAccount_LinkClicked;
            // 
            // checkBoxStayLoggedIn
            // 
            checkBoxStayLoggedIn.AutoSize = true;
            checkBoxStayLoggedIn.Location = new Point(111, 159);
            checkBoxStayLoggedIn.Name = "checkBoxStayLoggedIn";
            checkBoxStayLoggedIn.Size = new Size(103, 15);
            checkBoxStayLoggedIn.TabIndex = 2;
            checkBoxStayLoggedIn.Text = "Stay logged in?";
            checkBoxStayLoggedIn.UseSelectable = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(60, 211);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(90, 25);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "Settings";
            buttonSettings.UseSelectable = true;
            buttonSettings.Click += ButtonSettings_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 252);
            Controls.Add(buttonSettings);
            Controls.Add(checkBoxStayLoggedIn);
            Controls.Add(linkLabelCreateAccount);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(335, 240);
            Name = "FormLogin";
            Resizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Talkster";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PoisonLabel labelUsername;
        private PoisonTextBox textBoxUsername;
        private PoisonLabel labelPassword;
        private PoisonTextBox textBoxPassword;
        private PictureBox pictureBoxLogo;
        private PoisonButton buttonLogin;
        private PoisonButton buttonCancel;
        private PoisonLinkLabel linkLabelCreateAccount;
        private PoisonCheckBox checkBoxStayLoggedIn;
        private PoisonButton buttonSettings;
    }
}