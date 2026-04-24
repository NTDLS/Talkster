using NTDLS.WinFormsHelpers.Controls;
using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    /// <summary>
    /// Progress form used for multi-threaded progress reporting.
    /// </summary>
    internal partial class FormThemedProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemedProgress));
            buttonCancel = new PoisonButton();
            pbProgress = new PoisonProgressBar();
            labelHeader = new PoisonLabel();
            labelBody = new PoisonLabel();
            spinningActivity = new ActivityIndicator();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(289, 166);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // pbProgress
            // 
            pbProgress.Location = new Point(67, 133);
            pbProgress.Margin = new Padding(4, 3, 4, 3);
            pbProgress.Name = "pbProgress";
            pbProgress.ProgressBarMarqueeWidth = 103;
            pbProgress.Size = new Size(310, 27);
            pbProgress.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.Location = new Point(67, 60);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(314, 20);
            labelHeader.TabIndex = 3;
            labelHeader.Text = "Please wait...";
            // 
            // labelBody
            // 
            labelBody.Location = new Point(64, 98);
            labelBody.Margin = new Padding(4, 0, 4, 0);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(314, 20);
            labelBody.TabIndex = 4;
            labelBody.Text = "Please wait...";
            // 
            // spinningActivity
            // 
            spinningActivity.Location = new Point(21, 66);
            spinningActivity.Margin = new Padding(4, 0, 4, 0);
            spinningActivity.Name = "spinningActivity";
            spinningActivity.Size = new Size(35, 32);
            spinningActivity.TabIndex = 4;
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // FormThemedProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 209);
            Controls.Add(labelBody);
            Controls.Add(spinningActivity);
            Controls.Add(labelHeader);
            Controls.Add(pbProgress);
            Controls.Add(buttonCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemedProgress";
            Resizable = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Talkster";
            Shown += FormProgress_Shown;
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PoisonButton buttonCancel;
        private PoisonProgressBar pbProgress;
        private PoisonLabel labelHeader;
        private PoisonLabel labelBody;
        private ActivityIndicator spinningActivity;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
    }
}