using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            splitContainer1 = new SplitContainer();
            flowLayoutPanelChat = new FlowLayoutPanel();
            textBoxMessage = new PoisonTextBox();
            buttonSend = new PoisonButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(20, 60);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanelChat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxMessage);
            splitContainer1.Panel2.Controls.Add(buttonSend);
            splitContainer1.Size = new Size(544, 324);
            splitContainer1.SplitterDistance = 273;
            splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.BackColor = Color.Transparent;
            flowLayoutPanelChat.Dock = DockStyle.Fill;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.Location = new Point(0, 0);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(544, 273);
            flowLayoutPanelChat.TabIndex = 0;
            flowLayoutPanelChat.WrapContents = false;
            // 
            // textBoxMessage
            // 
            // 
            // 
            // 
            textBoxMessage.CustomButton.Image = null;
            textBoxMessage.CustomButton.Location = new Point(445, 1);
            textBoxMessage.CustomButton.Name = "";
            textBoxMessage.CustomButton.Size = new Size(45, 45);
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
            textBoxMessage.Size = new Size(491, 47);
            textBoxMessage.TabIndex = 1;
            textBoxMessage.UseSelectable = true;
            textBoxMessage.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxMessage.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // buttonSend
            // 
            buttonSend.Dock = DockStyle.Right;
            buttonSend.Location = new Point(491, 0);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(53, 47);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Send";
            buttonSend.UseSelectable = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 404);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTest";
            Text = "FormTest";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private PoisonTextBox textBoxMessage;
        private PoisonButton buttonSend;
        private FlowLayoutPanel flowLayoutPanelChat;
    }
}