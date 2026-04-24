using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            dataGridViewLog = new PoisonDataGridView();
            ColumnTimestamp = new DataGridViewTextBoxColumn();
            ColumnSeverity = new DataGridViewTextBoxColumn();
            ColumnMessage = new DataGridViewTextBoxColumn();
            poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            menuStrip = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.AllowUserToAddRows = false;
            dataGridViewLog.AllowUserToDeleteRows = false;
            dataGridViewLog.AllowUserToResizeRows = false;
            dataGridViewLog.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewLog.BorderStyle = BorderStyle.None;
            dataGridViewLog.CausesValidation = false;
            dataGridViewLog.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewLog.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Columns.AddRange(new DataGridViewColumn[] { ColumnTimestamp, ColumnSeverity, ColumnMessage });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewLog.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLog.Dock = DockStyle.Fill;
            dataGridViewLog.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewLog.EnableHeadersVisualStyles = false;
            dataGridViewLog.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewLog.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewLog.Location = new Point(20, 84);
            dataGridViewLog.MultiSelect = false;
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.ReadOnly = true;
            dataGridViewLog.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewLog.RowHeadersVisible = false;
            dataGridViewLog.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLog.ShowCellErrors = false;
            dataGridViewLog.ShowCellToolTips = false;
            dataGridViewLog.ShowEditingIcon = false;
            dataGridViewLog.ShowRowErrors = false;
            dataGridViewLog.Size = new Size(686, 346);
            dataGridViewLog.TabIndex = 3;
            // 
            // ColumnTimestamp
            // 
            ColumnTimestamp.FillWeight = 20F;
            ColumnTimestamp.HeaderText = "Timestamp";
            ColumnTimestamp.Name = "ColumnTimestamp";
            ColumnTimestamp.ReadOnly = true;
            // 
            // ColumnSeverity
            // 
            ColumnSeverity.FillWeight = 20F;
            ColumnSeverity.HeaderText = "Severity";
            ColumnSeverity.Name = "ColumnSeverity";
            ColumnSeverity.ReadOnly = true;
            // 
            // ColumnMessage
            // 
            ColumnMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnMessage.HeaderText = "Message";
            ColumnMessage.Name = "ColumnMessage";
            ColumnMessage.ReadOnly = true;
            // 
            // poisonStyleManager
            // 
            poisonStyleManager.Owner = this;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            menuStrip.Location = new Point(20, 60);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(686, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(dataGridViewLog);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimumSize = new Size(525, 450);
            Name = "FormLog";
            Text = "Talkster";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PoisonDataGridView dataGridViewLog;
        private DataGridViewTextBoxColumn ColumnTimestamp;
        private DataGridViewTextBoxColumn ColumnSeverity;
        private DataGridViewTextBoxColumn ColumnMessage;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
        private MenuStrip menuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}