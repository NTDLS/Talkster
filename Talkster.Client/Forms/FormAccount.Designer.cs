using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            labelUserName = new PoisonLabel();
            labelPassword = new PoisonLabel();
            textBoxUsername = new PoisonTextBox();
            textBoxPassword = new PoisonTextBox();
            buttonSave = new PoisonButton();
            buttonCancel = new PoisonButton();
            textBoxConfirmPassword = new PoisonTextBox();
            labelConfirmPassword = new PoisonLabel();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(8, 60);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(68, 19);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(8, 125);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(63, 19);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxUsernameName
            // 
            // 
            // 
            // 
            textBoxUsername.CustomButton.Image = null;
            textBoxUsername.CustomButton.Location = new Point(251, 1);
            textBoxUsername.CustomButton.Name = "";
            textBoxUsername.CustomButton.Size = new Size(21, 21);
            textBoxUsername.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxUsername.CustomButton.TabIndex = 1;
            textBoxUsername.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxUsername.CustomButton.UseSelectable = true;
            textBoxUsername.CustomButton.Visible = false;
            textBoxUsername.Location = new Point(8, 82);
            textBoxUsername.MaxLength = 32767;
            textBoxUsername.Name = "textBoxUsernameName";
            textBoxUsername.PasswordChar = '\0';
            textBoxUsername.ReadOnly = true;
            textBoxUsername.ScrollBars = ScrollBars.None;
            textBoxUsername.SelectedText = "";
            textBoxUsername.SelectionLength = 0;
            textBoxUsername.SelectionStart = 0;
            textBoxUsername.ShortcutsEnabled = true;
            textBoxUsername.Size = new Size(273, 23);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.UseSelectable = true;
            textBoxUsername.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxUsername.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            textBoxPassword.CustomButton.Image = null;
            textBoxPassword.CustomButton.Location = new Point(251, 1);
            textBoxPassword.CustomButton.Name = "";
            textBoxPassword.CustomButton.Size = new Size(21, 21);
            textBoxPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPassword.CustomButton.TabIndex = 1;
            textBoxPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPassword.CustomButton.UseSelectable = true;
            textBoxPassword.CustomButton.Visible = false;
            textBoxPassword.Location = new Point(8, 147);
            textBoxPassword.MaxLength = 32767;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '\0';
            textBoxPassword.ScrollBars = ScrollBars.None;
            textBoxPassword.SelectedText = "";
            textBoxPassword.SelectionLength = 0;
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.ShortcutsEnabled = true;
            textBoxPassword.Size = new Size(273, 23);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSelectable = true;
            textBoxPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(125, 224);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseSelectable = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(206, 224);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // TextBoxConfirmPassword
            // 
            // 
            // 
            // 
            textBoxConfirmPassword.CustomButton.Image = null;
            textBoxConfirmPassword.CustomButton.Location = new Point(251, 1);
            textBoxConfirmPassword.CustomButton.Name = "";
            textBoxConfirmPassword.CustomButton.Size = new Size(21, 21);
            textBoxConfirmPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxConfirmPassword.CustomButton.TabIndex = 1;
            textBoxConfirmPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxConfirmPassword.CustomButton.UseSelectable = true;
            textBoxConfirmPassword.CustomButton.Visible = false;
            textBoxConfirmPassword.Location = new Point(8, 195);
            textBoxConfirmPassword.MaxLength = 32767;
            textBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '\0';
            textBoxConfirmPassword.ScrollBars = ScrollBars.None;
            textBoxConfirmPassword.SelectedText = "";
            textBoxConfirmPassword.SelectionLength = 0;
            textBoxConfirmPassword.SelectionStart = 0;
            textBoxConfirmPassword.ShortcutsEnabled = true;
            textBoxConfirmPassword.Size = new Size(273, 23);
            textBoxConfirmPassword.TabIndex = 10;
            textBoxConfirmPassword.UseSelectable = true;
            textBoxConfirmPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxConfirmPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(8, 173);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(115, 19);
            labelConfirmPassword.TabIndex = 9;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 261);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAccount";
            Resizable = false;
            Text = "Talkster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private PoisonLabel labelUserName;
        private PoisonTextBox textBoxUsername;
        private PoisonLabel labelPassword;
        private PoisonTextBox textBoxPassword;
        private PoisonButton buttonSave;
        private PoisonButton buttonCancel;
        private PoisonTextBox textBoxConfirmPassword;
        private PoisonLabel labelConfirmPassword;
    }
}