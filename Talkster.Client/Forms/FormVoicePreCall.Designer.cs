using ReaLTaiizor.Controls;

namespace Talkster.Client.Forms
{
    partial class FormVoicePreCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoicePreCall));
            comboBoxAudioOutputDevice = new PoisonComboBox();
            labelAudioOutputDevice = new PoisonLabel();
            labelAudioInputDevice = new PoisonLabel();
            comboBoxAudioInputDevice = new PoisonComboBox();
            radioButtonBitRateHighFidelity = new PoisonRadioButton();
            radioButtonBitRateBalanced = new PoisonRadioButton();
            radioButtonBitRateStandard = new PoisonRadioButton();
            radioButtonBitRateLow = new PoisonRadioButton();
            buttonOk = new PoisonButton();
            buttonCancel = new PoisonButton();
            volumeMeterInput = new NAudio.Gui.VolumeMeter();
            panel1 = new PoisonPanel();
            label1 = new PoisonLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxAudioOutputDevice
            // 
            comboBoxAudioOutputDevice.DropDownWidth = 457;
            comboBoxAudioOutputDevice.FormattingEnabled = true;
            comboBoxAudioOutputDevice.ItemHeight = 23;
            comboBoxAudioOutputDevice.Location = new Point(23, 136);
            comboBoxAudioOutputDevice.Name = "comboBoxAudioOutputDevice";
            comboBoxAudioOutputDevice.Size = new Size(457, 29);
            comboBoxAudioOutputDevice.TabIndex = 1;
            comboBoxAudioOutputDevice.UseSelectable = true;
            // 
            // labelAudioOutputDevice
            // 
            labelAudioOutputDevice.AutoSize = true;
            labelAudioOutputDevice.Location = new Point(23, 114);
            labelAudioOutputDevice.Name = "labelAudioOutputDevice";
            labelAudioOutputDevice.Size = new Size(127, 19);
            labelAudioOutputDevice.TabIndex = 1;
            labelAudioOutputDevice.Text = "Audio output device";
            // 
            // labelAudioInputDevice
            // 
            labelAudioInputDevice.AutoSize = true;
            labelAudioInputDevice.Location = new Point(23, 60);
            labelAudioInputDevice.Name = "labelAudioInputDevice";
            labelAudioInputDevice.Size = new Size(118, 19);
            labelAudioInputDevice.TabIndex = 3;
            labelAudioInputDevice.Text = "Audio input device";
            // 
            // comboBoxAudioInputDevice
            // 
            comboBoxAudioInputDevice.DropDownWidth = 457;
            comboBoxAudioInputDevice.FormattingEnabled = true;
            comboBoxAudioInputDevice.ItemHeight = 23;
            comboBoxAudioInputDevice.Location = new Point(23, 82);
            comboBoxAudioInputDevice.Name = "comboBoxAudioInputDevice";
            comboBoxAudioInputDevice.Size = new Size(457, 29);
            comboBoxAudioInputDevice.TabIndex = 0;
            comboBoxAudioInputDevice.UseSelectable = true;
            // 
            // radioButtonBitRateHighFidelity
            // 
            radioButtonBitRateHighFidelity.AutoSize = true;
            radioButtonBitRateHighFidelity.Location = new Point(3, 79);
            radioButtonBitRateHighFidelity.Name = "radioButtonBitRateHighFidelity";
            radioButtonBitRateHighFidelity.Size = new Size(141, 15);
            radioButtonBitRateHighFidelity.TabIndex = 5;
            radioButtonBitRateHighFidelity.Text = "High-fidelity (96 kbps)";
            radioButtonBitRateHighFidelity.UseSelectable = true;
            // 
            // radioButtonBitRateBalanced
            // 
            radioButtonBitRateBalanced.AutoSize = true;
            radioButtonBitRateBalanced.Location = new Point(3, 54);
            radioButtonBitRateBalanced.Name = "radioButtonBitRateBalanced";
            radioButtonBitRateBalanced.Size = new Size(122, 15);
            radioButtonBitRateBalanced.TabIndex = 4;
            radioButtonBitRateBalanced.Text = "Balanced (64 kbps)";
            radioButtonBitRateBalanced.UseSelectable = true;
            // 
            // radioButtonBitRateStandard
            // 
            radioButtonBitRateStandard.AutoSize = true;
            radioButtonBitRateStandard.Checked = true;
            radioButtonBitRateStandard.Location = new Point(3, 29);
            radioButtonBitRateStandard.Name = "radioButtonBitRateStandard";
            radioButtonBitRateStandard.Size = new Size(121, 15);
            radioButtonBitRateStandard.TabIndex = 3;
            radioButtonBitRateStandard.TabStop = true;
            radioButtonBitRateStandard.Text = "Standard (32 kbps)";
            radioButtonBitRateStandard.UseSelectable = true;
            // 
            // radioButtonBitRateLow
            // 
            radioButtonBitRateLow.AutoSize = true;
            radioButtonBitRateLow.Location = new Point(3, 4);
            radioButtonBitRateLow.Name = "radioButtonBitRateLow";
            radioButtonBitRateLow.Size = new Size(96, 15);
            radioButtonBitRateLow.TabIndex = 2;
            radioButtonBitRateLow.Text = "Low (16 kbps)";
            radioButtonBitRateLow.UseSelectable = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(324, 271);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseSelectable = true;
            buttonOk.Click += ButtonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(405, 271);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseSelectable = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // volumeMeterInput
            // 
            volumeMeterInput.Amplitude = 0F;
            volumeMeterInput.ForeColor = Color.SpringGreen;
            volumeMeterInput.Location = new Point(182, 189);
            volumeMeterInput.MaxDb = 18F;
            volumeMeterInput.MinDb = -60F;
            volumeMeterInput.Name = "volumeMeterInput";
            volumeMeterInput.Size = new Size(13, 105);
            volumeMeterInput.TabIndex = 9;
            volumeMeterInput.Text = "volumeMeterInput";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonBitRateLow);
            panel1.Controls.Add(radioButtonBitRateHighFidelity);
            panel1.Controls.Add(radioButtonBitRateStandard);
            panel1.Controls.Add(radioButtonBitRateBalanced);
            panel1.HorizontalScrollbarBarColor = true;
            panel1.HorizontalScrollbarHighlightOnWheel = false;
            panel1.HorizontalScrollbarSize = 10;
            panel1.Location = new Point(23, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 105);
            panel1.TabIndex = 13;
            panel1.VerticalScrollbarBarColor = true;
            panel1.VerticalScrollbarHighlightOnWheel = false;
            panel1.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 167);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 14;
            label1.Text = "Quality (Sample Rate)";
            // 
            // FormVoicePreCall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 315);
            Controls.Add(panel1);
            Controls.Add(volumeMeterInput);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxAudioInputDevice);
            Controls.Add(comboBoxAudioOutputDevice);
            Controls.Add(labelAudioInputDevice);
            Controls.Add(labelAudioOutputDevice);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVoicePreCall";
            Resizable = false;
            Text = "Talkster : Call Setup";
            Load += FormVoicePreCall_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PoisonComboBox comboBoxAudioOutputDevice;
        private PoisonLabel labelAudioOutputDevice;
        private PoisonLabel labelAudioInputDevice;
        private PoisonComboBox comboBoxAudioInputDevice;
        private PoisonRadioButton radioButtonBitRateHighFidelity;
        private PoisonRadioButton radioButtonBitRateBalanced;
        private PoisonRadioButton radioButtonBitRateStandard;
        private PoisonRadioButton radioButtonBitRateLow;
        private PoisonButton buttonOk;
        private PoisonButton buttonCancel;
        private NAudio.Gui.VolumeMeter volumeMeterInput;
        private PoisonPanel panel1;
        private PoisonLabel label1;
    }
}