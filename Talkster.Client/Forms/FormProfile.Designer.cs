using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            labelWarning = new PoisonLabel();
            labelDisplayName = new PoisonLabel();
            labelTagline = new PoisonLabel();
            textBoxDisplayName = new PoisonTextBox();
            textBoxTagline = new PoisonTextBox();
            buttonSave = new PoisonButton();
            buttonCancel = new PoisonButton();
            textBoxBiography = new PoisonTextBox();
            labelBiography = new PoisonLabel();
            SuspendLayout();
            // 
            // labelWarning
            // 
            labelWarning.Location = new Point(23, 60);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(244, 20);
            labelWarning.TabIndex = 0;
            labelWarning.Text = "This profile is viewable to your contacts.";
            // 
            // labelDisplayName
            // 
            labelDisplayName.AutoSize = true;
            labelDisplayName.Location = new Point(8, 86);
            labelDisplayName.Name = "labelDisplayName";
            labelDisplayName.Size = new Size(90, 19);
            labelDisplayName.TabIndex = 1;
            labelDisplayName.Text = "Display Name";
            // 
            // labelTagline
            // 
            labelTagline.AutoSize = true;
            labelTagline.Location = new Point(8, 132);
            labelTagline.Name = "labelTagline";
            labelTagline.Size = new Size(49, 19);
            labelTagline.TabIndex = 2;
            labelTagline.Text = "Tagline";
            // 
            // textBoxDisplayName
            // 
            // 
            // 
            // 
            textBoxDisplayName.CustomButton.Image = null;
            textBoxDisplayName.CustomButton.Location = new Point(251, 1);
            textBoxDisplayName.CustomButton.Name = "";
            textBoxDisplayName.CustomButton.Size = new Size(21, 21);
            textBoxDisplayName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxDisplayName.CustomButton.TabIndex = 1;
            textBoxDisplayName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxDisplayName.CustomButton.UseSelectable = true;
            textBoxDisplayName.CustomButton.Visible = false;
            textBoxDisplayName.Location = new Point(12, 106);
            textBoxDisplayName.MaxLength = 32767;
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.PasswordChar = '\0';
            textBoxDisplayName.ScrollBars = ScrollBars.None;
            textBoxDisplayName.SelectedText = "";
            textBoxDisplayName.SelectionLength = 0;
            textBoxDisplayName.SelectionStart = 0;
            textBoxDisplayName.ShortcutsEnabled = true;
            textBoxDisplayName.Size = new Size(273, 23);
            textBoxDisplayName.TabIndex = 5;
            textBoxDisplayName.UseSelectable = true;
            textBoxDisplayName.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxDisplayName.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxTagline
            // 
            // 
            // 
            // 
            textBoxTagline.CustomButton.Image = null;
            textBoxTagline.CustomButton.Location = new Point(251, 1);
            textBoxTagline.CustomButton.Name = "";
            textBoxTagline.CustomButton.Size = new Size(21, 21);
            textBoxTagline.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxTagline.CustomButton.TabIndex = 1;
            textBoxTagline.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxTagline.CustomButton.UseSelectable = true;
            textBoxTagline.CustomButton.Visible = false;
            textBoxTagline.Location = new Point(12, 152);
            textBoxTagline.MaxLength = 32767;
            textBoxTagline.Name = "textBoxTagline";
            textBoxTagline.PasswordChar = '\0';
            textBoxTagline.ScrollBars = ScrollBars.None;
            textBoxTagline.SelectedText = "";
            textBoxTagline.SelectionLength = 0;
            textBoxTagline.SelectionStart = 0;
            textBoxTagline.ShortcutsEnabled = true;
            textBoxTagline.Size = new Size(273, 23);
            textBoxTagline.TabIndex = 6;
            textBoxTagline.UseSelectable = true;
            textBoxTagline.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxTagline.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(129, 291);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseSelectable = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(210, 291);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxBiography
            // 
            // 
            // 
            // 
            textBoxBiography.CustomButton.Image = null;
            textBoxBiography.CustomButton.Location = new Point(189, 2);
            textBoxBiography.CustomButton.Name = "";
            textBoxBiography.CustomButton.Size = new Size(81, 81);
            textBoxBiography.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxBiography.CustomButton.TabIndex = 1;
            textBoxBiography.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxBiography.CustomButton.UseSelectable = true;
            textBoxBiography.CustomButton.Visible = false;
            textBoxBiography.Location = new Point(12, 198);
            textBoxBiography.MaxLength = 32767;
            textBoxBiography.Multiline = true;
            textBoxBiography.Name = "textBoxBiography";
            textBoxBiography.PasswordChar = '\0';
            textBoxBiography.ScrollBars = ScrollBars.None;
            textBoxBiography.SelectedText = "";
            textBoxBiography.SelectionLength = 0;
            textBoxBiography.SelectionStart = 0;
            textBoxBiography.ShortcutsEnabled = true;
            textBoxBiography.Size = new Size(273, 86);
            textBoxBiography.TabIndex = 10;
            textBoxBiography.UseSelectable = true;
            textBoxBiography.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxBiography.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelBiography
            // 
            labelBiography.AutoSize = true;
            labelBiography.Location = new Point(8, 178);
            labelBiography.Name = "labelBiography";
            labelBiography.Size = new Size(69, 19);
            labelBiography.TabIndex = 9;
            labelBiography.Text = "Biography";
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 338);
            Controls.Add(textBoxBiography);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTagline);
            Controls.Add(textBoxDisplayName);
            Controls.Add(labelWarning);
            Controls.Add(labelBiography);
            Controls.Add(labelTagline);
            Controls.Add(labelDisplayName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProfile";
            Resizable = false;
            Text = "Talkster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PoisonLabel labelWarning;
        private PoisonLabel labelDisplayName;
        private PoisonLabel labelTagline;
        private PoisonTextBox textBoxDisplayName;
        private PoisonTextBox textBoxTagline;
        private PoisonButton buttonSave;
        private PoisonButton buttonCancel;
        private PoisonTextBox textBoxBiography;
        private PoisonLabel labelBiography;
    }
}