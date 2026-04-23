using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormFindPeople
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindPeople));
            textBoxDisplayName = new PoisonTextBox();
            labelDisplayName = new PoisonLabel();
            buttonSearch = new PoisonButton();
            dataGridViewAccounts = new PoisonDataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnState = new DataGridViewTextBoxColumn();
            Invite = new DataGridViewButtonColumn();
            splitContainer1 = new SplitContainer();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            SuspendLayout();
            // 
            // textBoxDisplayName
            // 
            // 
            // 
            // 
            textBoxDisplayName.CustomButton.Image = null;
            textBoxDisplayName.CustomButton.Location = new Point(391, 1);
            textBoxDisplayName.CustomButton.Name = "";
            textBoxDisplayName.CustomButton.Size = new Size(21, 21);
            textBoxDisplayName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxDisplayName.CustomButton.TabIndex = 1;
            textBoxDisplayName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxDisplayName.CustomButton.UseSelectable = true;
            textBoxDisplayName.CustomButton.Visible = false;
            textBoxDisplayName.Location = new Point(5, 23);
            textBoxDisplayName.MaxLength = 32767;
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.PasswordChar = '\0';
            textBoxDisplayName.ScrollBars = ScrollBars.None;
            textBoxDisplayName.SelectedText = "";
            textBoxDisplayName.SelectionLength = 0;
            textBoxDisplayName.SelectionStart = 0;
            textBoxDisplayName.ShortcutsEnabled = true;
            textBoxDisplayName.Size = new Size(413, 23);
            textBoxDisplayName.TabIndex = 0;
            textBoxDisplayName.UseSelectable = true;
            textBoxDisplayName.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxDisplayName.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // labelDisplayName
            // 
            labelDisplayName.AutoSize = true;
            labelDisplayName.Location = new Point(1, 3);
            labelDisplayName.Name = "labelDisplayName";
            labelDisplayName.Size = new Size(90, 19);
            labelDisplayName.TabIndex = 1;
            labelDisplayName.Text = "Display Name";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(424, 23);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(58, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseSelectable = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.AllowUserToAddRows = false;
            dataGridViewAccounts.AllowUserToDeleteRows = false;
            dataGridViewAccounts.AllowUserToResizeRows = false;
            dataGridViewAccounts.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewAccounts.BorderStyle = BorderStyle.None;
            dataGridViewAccounts.CausesValidation = false;
            dataGridViewAccounts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAccounts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnState, Invite });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccounts.Dock = DockStyle.Fill;
            dataGridViewAccounts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAccounts.EnableHeadersVisualStyles = false;
            dataGridViewAccounts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewAccounts.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewAccounts.Location = new Point(0, 0);
            dataGridViewAccounts.MultiSelect = false;
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.ReadOnly = true;
            dataGridViewAccounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAccounts.RowHeadersVisible = false;
            dataGridViewAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAccounts.ShowCellErrors = false;
            dataGridViewAccounts.ShowCellToolTips = false;
            dataGridViewAccounts.ShowEditingIcon = false;
            dataGridViewAccounts.ShowRowErrors = false;
            dataGridViewAccounts.Size = new Size(485, 317);
            dataGridViewAccounts.TabIndex = 3;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 300;
            // 
            // ColumnState
            // 
            ColumnState.HeaderText = "State";
            ColumnState.Name = "ColumnState";
            ColumnState.ReadOnly = true;
            // 
            // Invite
            // 
            Invite.HeaderText = "Invite";
            Invite.Name = "Invite";
            Invite.ReadOnly = true;
            Invite.Width = 80;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(20, 60);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxDisplayName);
            splitContainer1.Panel1.Controls.Add(buttonSearch);
            splitContainer1.Panel1.Controls.Add(labelDisplayName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewAccounts);
            splitContainer1.Size = new Size(485, 370);
            splitContainer1.SplitterDistance = 49;
            splitContainer1.TabIndex = 4;
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // FormFindPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(525, 450);
            Name = "FormFindPeople";
            Text = "Talkster";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PoisonTextBox textBoxDisplayName;
        private PoisonLabel labelDisplayName;
        private PoisonButton buttonSearch;
        private PoisonDataGridView dataGridViewAccounts;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnState;
        private DataGridViewButtonColumn Invite;
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
    }
}