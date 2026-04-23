using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            buttonOk = new PoisonButton();
            linkWebsite = new PoisonLinkLabel();
            listViewVersions = new PoisonListView();
            columnHeaderApplication = new ColumnHeader();
            columnHeaderVersion = new ColumnHeader();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 86);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(408, 222);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(88, 27);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseSelectable = true;
            buttonOk.Click += ButtonOk_Click;
            // 
            // linkWebsite
            // 
            linkWebsite.AutoSize = true;
            linkWebsite.Location = new Point(159, 222);
            linkWebsite.Margin = new Padding(4, 0, 4, 0);
            linkWebsite.Name = "linkWebsite";
            linkWebsite.Size = new Size(164, 25);
            linkWebsite.TabIndex = 9;
            linkWebsite.Text = "www.NetworkDLS.com";
            linkWebsite.UseSelectable = true;
            linkWebsite.Click += LinkWebsite_LinkClicked;
            // 
            // listViewVersions
            // 
            listViewVersions.Columns.AddRange(new ColumnHeader[] { columnHeaderApplication, columnHeaderVersion });
            listViewVersions.Font = new Font("Segoe UI", 12F);
            listViewVersions.FullRowSelect = true;
            listViewVersions.HideSelection = true;
            listViewVersions.Location = new Point(159, 63);
            listViewVersions.Name = "listViewVersions";
            listViewVersions.OwnerDraw = true;
            listViewVersions.Size = new Size(337, 153);
            listViewVersions.TabIndex = 12;
            listViewVersions.UseCompatibleStateImageBehavior = false;
            listViewVersions.UseSelectable = true;
            listViewVersions.View = View.Details;
            // 
            // columnHeaderApplication
            // 
            columnHeaderApplication.Text = "Application";
            columnHeaderApplication.Width = 150;
            // 
            // columnHeaderVersion
            // 
            columnHeaderVersion.Text = "Version";
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 267);
            Controls.Add(listViewVersions);
            Controls.Add(linkWebsite);
            Controls.Add(buttonOk);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Talkster";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PoisonButton buttonOk;
        private PoisonLinkLabel linkWebsite;
        private PoisonListView listViewVersions;
        private ColumnHeader columnHeaderApplication;
        private ColumnHeader columnHeaderVersion;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
    }
}