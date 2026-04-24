using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormToast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToast));
            labelHeader = new PoisonLabel();
            labelBody = new PoisonLabel();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            pictureBoxIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHeader.Location = new Point(51, 14);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(80, 19);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "labelHeader";
            // 
            // labelBody
            // 
            labelBody.Location = new Point(51, 33);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(276, 46);
            labelBody.TabIndex = 2;
            labelBody.Text = "labelBody";
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.AppLogo32;
            pictureBoxIcon.Location = new Point(9, 14);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(36, 38);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxIcon.TabIndex = 4;
            pictureBoxIcon.TabStop = false;
            // 
            // FormToast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 94);
            Controls.Add(pictureBoxIcon);
            Controls.Add(labelBody);
            Controls.Add(labelHeader);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(350, 90);
            Movable = false;
            Name = "FormToast";
            Opacity = 0.9D;
            Resizable = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PoisonLabel labelHeader;
        private PoisonLabel labelBody;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
        private PictureBox pictureBoxIcon;
    }
}