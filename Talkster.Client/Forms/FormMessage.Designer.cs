using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            splitContainer1 = new SplitContainer();
            flowPanel = new FlowLayoutPanel();
            textBoxMessage = new PoisonTextBox();
            buttonSend = new PoisonButton();
            toolStrip1 = new ToolStrip();
            toolStripButtonTerminate = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonAttachFile = new ToolStripButton();
            toolStripButtonVoiceCall = new ToolStripButton();
            toolStripButtonVoiceCallEnd = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonExport = new ToolStripButton();
            toolStripButtonProperties = new ToolStripButton();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(5, 85);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxMessage);
            splitContainer1.Panel2.Controls.Add(buttonSend);
            splitContainer1.Size = new Size(534, 376);
            splitContainer1.SplitterDistance = 318;
            splitContainer1.TabIndex = 2;
            // 
            // flowPanel
            // 
            flowPanel.AllowDrop = true;
            flowPanel.AutoScroll = true;
            flowPanel.AutoSize = true;
            flowPanel.BackColor = Color.Transparent;
            flowPanel.BorderStyle = BorderStyle.Fixed3D;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(534, 318);
            flowPanel.TabIndex = 2;
            flowPanel.WrapContents = false;
            // 
            // textBoxMessage
            // 
            // 
            // 
            // 
            textBoxMessage.CustomButton.Image = null;
            textBoxMessage.CustomButton.Location = new Point(425, 2);
            textBoxMessage.CustomButton.Name = "";
            textBoxMessage.CustomButton.Size = new Size(49, 49);
            textBoxMessage.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxMessage.CustomButton.TabIndex = 1;
            textBoxMessage.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxMessage.CustomButton.UseSelectable = true;
            textBoxMessage.CustomButton.Visible = false;
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Location = new Point(0, 0);
            textBoxMessage.MaxLength = 32767;
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.PasswordChar = '\0';
            textBoxMessage.ScrollBars = ScrollBars.None;
            textBoxMessage.SelectedText = "";
            textBoxMessage.SelectionLength = 0;
            textBoxMessage.SelectionStart = 0;
            textBoxMessage.ShortcutsEnabled = true;
            textBoxMessage.Size = new Size(477, 54);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.UseSelectable = true;
            textBoxMessage.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxMessage.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // buttonSend
            // 
            buttonSend.Dock = DockStyle.Right;
            buttonSend.Location = new Point(477, 0);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(57, 54);
            buttonSend.TabIndex = 1;
            buttonSend.Text = "Send";
            buttonSend.UseSelectable = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonTerminate, toolStripSeparator1, toolStripButtonAttachFile, toolStripButtonVoiceCall, toolStripButtonVoiceCallEnd, toolStripSeparator2, toolStripButtonExport, toolStripButtonProperties });
            toolStrip1.Location = new Point(5, 60);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(534, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTerminate
            // 
            toolStripButtonTerminate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonTerminate.Image = (Image)resources.GetObject("toolStripButtonTerminate.Image");
            toolStripButtonTerminate.ImageTransparentColor = Color.Magenta;
            toolStripButtonTerminate.Name = "toolStripButtonTerminate";
            toolStripButtonTerminate.Size = new Size(23, 22);
            toolStripButtonTerminate.Text = "Terminate";
            toolStripButtonTerminate.ToolTipText = "Terminate";
            toolStripButtonTerminate.Click += ToolStripButtonTerminate_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonAttachFile
            // 
            toolStripButtonAttachFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAttachFile.Image = (Image)resources.GetObject("toolStripButtonAttachFile.Image");
            toolStripButtonAttachFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonAttachFile.Name = "toolStripButtonAttachFile";
            toolStripButtonAttachFile.Size = new Size(23, 22);
            toolStripButtonAttachFile.Text = "Attach File";
            toolStripButtonAttachFile.Click += ToolStripButtonAttachFile_Click;
            // 
            // toolStripButtonVoiceCall
            // 
            toolStripButtonVoiceCall.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonVoiceCall.Image = (Image)resources.GetObject("toolStripButtonVoiceCall.Image");
            toolStripButtonVoiceCall.ImageTransparentColor = Color.Magenta;
            toolStripButtonVoiceCall.Name = "toolStripButtonVoiceCall";
            toolStripButtonVoiceCall.Size = new Size(23, 22);
            toolStripButtonVoiceCall.Text = "Voice Call";
            toolStripButtonVoiceCall.Click += ToolStripButtonVoiceCall_Click;
            // 
            // toolStripButtonVoiceCallEnd
            // 
            toolStripButtonVoiceCallEnd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonVoiceCallEnd.Enabled = false;
            toolStripButtonVoiceCallEnd.Image = (Image)resources.GetObject("toolStripButtonVoiceCallEnd.Image");
            toolStripButtonVoiceCallEnd.ImageTransparentColor = Color.Magenta;
            toolStripButtonVoiceCallEnd.Name = "toolStripButtonVoiceCallEnd";
            toolStripButtonVoiceCallEnd.Size = new Size(23, 22);
            toolStripButtonVoiceCallEnd.Text = "End Voice Call";
            toolStripButtonVoiceCallEnd.Click += ToolStripButtonVoiceCallEnd_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButtonExport
            // 
            toolStripButtonExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExport.Image = (Image)resources.GetObject("toolStripButtonExport.Image");
            toolStripButtonExport.ImageTransparentColor = Color.Magenta;
            toolStripButtonExport.Name = "toolStripButtonExport";
            toolStripButtonExport.Size = new Size(23, 22);
            toolStripButtonExport.Text = "Export";
            toolStripButtonExport.Click += ToolStripButtonExport_Click;
            // 
            // toolStripButtonProperties
            // 
            toolStripButtonProperties.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonProperties.Image = (Image)resources.GetObject("toolStripButtonProperties.Image");
            toolStripButtonProperties.ImageTransparentColor = Color.Magenta;
            toolStripButtonProperties.Name = "toolStripButtonProperties";
            toolStripButtonProperties.Size = new Size(23, 22);
            toolStripButtonProperties.Text = "Properties";
            toolStripButtonProperties.Click += ToolStripButtonProperties_Click;
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // FormMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 481);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 400);
            Name = "FormMessage";
            Opacity = 0.95D;
            Padding = new Padding(5, 60, 5, 20);
            PoisonBorderStyle = ReaLTaiizor.Enum.Poison.FormBorderStyle.FixedSingle;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "Talkster";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private PoisonTextBox textBoxMessage;
        private PoisonButton buttonSend;
        private FlowLayoutPanel flowPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAttachFile;
        private ToolStripButton toolStripButtonTerminate;
        private ToolStripButton toolStripButtonProperties;
        private ToolStripButton toolStripButtonVoiceCall;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonExport;
        private ToolStripButton toolStripButtonVoiceCallEnd;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
    }
}