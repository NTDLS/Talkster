﻿using Krypton.Toolkit;
using NTDLS.Helpers;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Talkster.Client.Controls.FlowControls;

namespace Talkster.Client.Controls
{
    internal partial class FlowControlOutgoingCall
        : UserControl, IFlowControl
    {
        private readonly FlowLayoutPanel _parent;
        private readonly ActiveChat _activeChat;

        [AllowNull]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get => Invoke(() => labelOutgoingCallTo.Text);
            set => Invoke(() => labelOutgoingCallTo.Text = value);
        }

        public void Disable()
        {
            Invoke(() => buttonCancel.Enabled = false);
        }

        public FlowControlOutgoingCall(FlowLayoutPanel parent, ActiveChat activeChat, string toName)
        {
            InitializeComponent();

            BackColor = KryptonManager.CurrentGlobalPalette.GetBackColor1(PaletteBackStyle.PanelClient, PaletteState.Normal);

            _activeChat = activeChat;
            _parent = parent;

            labelOutgoingCallTo.Text = $"Outgoing call to {toName}...";

            MouseClick += Control_MouseClick;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            _activeChat.CancelVoiceCallRequest();
        }

        private void Control_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Copy", null, (a, b) => OnCopy(sender, new EventArgs()));
                contextMenu.Items.Add(new ToolStripSeparator());
                contextMenu.Items.Add("Remove", null, OnRemove);
                contextMenu.Show((sender as Control) ?? this, e.Location);
            }
        }

        private void OnRemove(object? sender, EventArgs e)
        {
            Remove();
        }

        private void OnCopy(object? sender, EventArgs e)
        {
            Exceptions.Ignore(() =>
            {
                if (sender is LinkLabel linkLabel)
                {
                    Clipboard.SetText(linkLabel.Text);
                }
            });
        }

        public void Remove()
        {
            Exceptions.Ignore(() =>
            {
                _parent.Controls.Remove(this);
            });
        }
    }
}
