using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            buttonCreate = new PoisonButton();
            buttonCancel = new PoisonButton();
            labelUsername = new PoisonLabel();
            labelDisplayName = new PoisonLabel();
            labelPassword = new PoisonLabel();
            textBoxUsername = new PoisonTextBox();
            textBoxDisplayName = new PoisonTextBox();
            textBoxPassword = new PoisonTextBox();
            textBoxConfirmPassword = new PoisonTextBox();
            labelConfirmPassword = new PoisonLabel();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(113, 262);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create";
            buttonCreate.UseSelectable = true;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(194, 262);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(23, 60);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(68, 19);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelDisplayName
            // 
            labelDisplayName.AutoSize = true;
            labelDisplayName.Location = new Point(23, 105);
            labelDisplayName.Name = "labelDisplayName";
            labelDisplayName.Size = new Size(90, 19);
            labelDisplayName.TabIndex = 3;
            labelDisplayName.Text = "Display Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(23, 166);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(63, 19);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            textBoxUsername.CustomButton.Image = null;
            textBoxUsername.CustomButton.Location = new Point(220, 1);
            textBoxUsername.CustomButton.Name = "";
            textBoxUsername.CustomButton.Size = new Size(21, 21);
            textBoxUsername.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxUsername.CustomButton.TabIndex = 1;
            textBoxUsername.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxUsername.CustomButton.UseSelectable = true;
            textBoxUsername.CustomButton.Visible = false;
            textBoxUsername.Location = new Point(27, 80);
            textBoxUsername.MaxLength = 32767;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PasswordChar = '\0';
            textBoxUsername.ScrollBars = ScrollBars.None;
            textBoxUsername.SelectedText = "";
            textBoxUsername.SelectionLength = 0;
            textBoxUsername.SelectionStart = 0;
            textBoxUsername.ShortcutsEnabled = true;
            textBoxUsername.Size = new Size(242, 23);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.UseSelectable = true;
            textBoxUsername.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxUsername.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxDisplayName
            // 
            // 
            // 
            // 
            textBoxDisplayName.CustomButton.Image = null;
            textBoxDisplayName.CustomButton.Location = new Point(220, 1);
            textBoxDisplayName.CustomButton.Name = "";
            textBoxDisplayName.CustomButton.Size = new Size(21, 21);
            textBoxDisplayName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxDisplayName.CustomButton.TabIndex = 1;
            textBoxDisplayName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxDisplayName.CustomButton.UseSelectable = true;
            textBoxDisplayName.CustomButton.Visible = false;
            textBoxDisplayName.Location = new Point(27, 125);
            textBoxDisplayName.MaxLength = 32767;
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.PasswordChar = '\0';
            textBoxDisplayName.ScrollBars = ScrollBars.None;
            textBoxDisplayName.SelectedText = "";
            textBoxDisplayName.SelectionLength = 0;
            textBoxDisplayName.SelectionStart = 0;
            textBoxDisplayName.ShortcutsEnabled = true;
            textBoxDisplayName.Size = new Size(242, 23);
            textBoxDisplayName.TabIndex = 1;
            textBoxDisplayName.UseSelectable = true;
            textBoxDisplayName.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxDisplayName.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            textBoxPassword.CustomButton.Image = null;
            textBoxPassword.CustomButton.Location = new Point(220, 1);
            textBoxPassword.CustomButton.Name = "";
            textBoxPassword.CustomButton.Size = new Size(21, 21);
            textBoxPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPassword.CustomButton.TabIndex = 1;
            textBoxPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPassword.CustomButton.UseSelectable = true;
            textBoxPassword.CustomButton.Visible = false;
            textBoxPassword.Location = new Point(27, 186);
            textBoxPassword.MaxLength = 32767;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.ScrollBars = ScrollBars.None;
            textBoxPassword.SelectedText = "";
            textBoxPassword.SelectionLength = 0;
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.ShortcutsEnabled = true;
            textBoxPassword.Size = new Size(242, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSelectable = true;
            textBoxPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxConfirmPassword
            // 
            // 
            // 
            // 
            textBoxConfirmPassword.CustomButton.Image = null;
            textBoxConfirmPassword.CustomButton.Location = new Point(220, 1);
            textBoxConfirmPassword.CustomButton.Name = "";
            textBoxConfirmPassword.CustomButton.Size = new Size(21, 21);
            textBoxConfirmPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxConfirmPassword.CustomButton.TabIndex = 1;
            textBoxConfirmPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxConfirmPassword.CustomButton.UseSelectable = true;
            textBoxConfirmPassword.CustomButton.Visible = false;
            textBoxConfirmPassword.Location = new Point(27, 231);
            textBoxConfirmPassword.MaxLength = 32767;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.ScrollBars = ScrollBars.None;
            textBoxConfirmPassword.SelectedText = "";
            textBoxConfirmPassword.SelectionLength = 0;
            textBoxConfirmPassword.SelectionStart = 0;
            textBoxConfirmPassword.ShortcutsEnabled = true;
            textBoxConfirmPassword.Size = new Size(242, 23);
            textBoxConfirmPassword.TabIndex = 3;
            textBoxConfirmPassword.UseSelectable = true;
            textBoxConfirmPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxConfirmPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(23, 211);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(115, 19);
            labelConfirmPassword.TabIndex = 9;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // FormCreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 313);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxDisplayName);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(labelConfirmPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelDisplayName);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreateAccount";
            Resizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Talkster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PoisonButton buttonCreate;
        private PoisonButton buttonCancel;
        private PoisonLabel labelUsername;
        private PoisonLabel labelDisplayName;
        private PoisonLabel labelPassword;
        private PoisonTextBox textBoxUsername;
        private PoisonTextBox textBoxDisplayName;
        private PoisonTextBox textBoxPassword;
        private PoisonTextBox textBoxConfirmPassword;
        private PoisonLabel labelConfirmPassword;
    }
}