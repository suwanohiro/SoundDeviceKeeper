namespace SoundDeviceKeeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Power = new Button();
            PowerUI = new Label();
            label1 = new Label();
            ChangeDefaultDeviceButton = new Button();
            label2 = new Label();
            CurrentAudioDeviceName = new Label();
            label3 = new Label();
            DefaultAudioDeviceName = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            GitHub = new ToolStripStatusLabel();
            UpdateHistory = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Power
            // 
            Power.Location = new Point(12, 12);
            Power.Name = "Power";
            Power.Size = new Size(75, 23);
            Power.TabIndex = 0;
            Power.Text = "ON";
            Power.UseVisualStyleBackColor = true;
            Power.Click += FormEvent_Power_Click;
            // 
            // PowerUI
            // 
            PowerUI.BorderStyle = BorderStyle.FixedSingle;
            PowerUI.Location = new Point(93, 12);
            PowerUI.Name = "PowerUI";
            PowerUI.Size = new Size(100, 23);
            PowerUI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 2;
            label1.Text = "現在のデバイスを規定のデバイスとして設定：";
            // 
            // ChangeDefaultDeviceButton
            // 
            ChangeDefaultDeviceButton.Location = new Point(238, 62);
            ChangeDefaultDeviceButton.Name = "ChangeDefaultDeviceButton";
            ChangeDefaultDeviceButton.Size = new Size(75, 23);
            ChangeDefaultDeviceButton.TabIndex = 3;
            ChangeDefaultDeviceButton.Text = "セット";
            ChangeDefaultDeviceButton.UseVisualStyleBackColor = true;
            ChangeDefaultDeviceButton.Click += ChangeDefaultDeviceButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 88);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 4;
            label2.Text = "現在の音声出力デバイス：";
            // 
            // CurrentAudioDeviceName
            // 
            CurrentAudioDeviceName.AutoSize = true;
            CurrentAudioDeviceName.Location = new Point(238, 88);
            CurrentAudioDeviceName.Name = "CurrentAudioDeviceName";
            CurrentAudioDeviceName.Size = new Size(96, 15);
            CurrentAudioDeviceName.TabIndex = 5;
            CurrentAudioDeviceName.Text = "No Audio Device";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 109);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 6;
            label3.Text = "設定中の規定のデバイス：";
            // 
            // DefaultAudioDeviceName
            // 
            DefaultAudioDeviceName.AutoSize = true;
            DefaultAudioDeviceName.Location = new Point(238, 109);
            DefaultAudioDeviceName.Name = "DefaultAudioDeviceName";
            DefaultAudioDeviceName.Size = new Size(96, 15);
            DefaultAudioDeviceName.TabIndex = 7;
            DefaultAudioDeviceName.Text = "No Audio Device";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripStatusLabel1, GitHub, UpdateHistory });
            statusStrip1.Location = new Point(0, 136);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(582, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(44, 17);
            toolStripStatusLabel2.Text = "ver1.00";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(128, 17);
            toolStripStatusLabel1.Text = "Created by suwanohiro";
            // 
            // GitHub
            // 
            GitHub.IsLink = true;
            GitHub.Name = "GitHub";
            GitHub.Size = new Size(104, 17);
            GitHub.Text = "GitHub Repository";
            GitHub.Click += GitHub_Click;
            // 
            // UpdateHistory
            // 
            UpdateHistory.IsLink = true;
            UpdateHistory.Name = "UpdateHistory";
            UpdateHistory.Size = new Size(55, 17);
            UpdateHistory.Text = "更新履歴";
            UpdateHistory.Click += UpdateHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 158);
            Controls.Add(statusStrip1);
            Controls.Add(DefaultAudioDeviceName);
            Controls.Add(label3);
            Controls.Add(CurrentAudioDeviceName);
            Controls.Add(label2);
            Controls.Add(ChangeDefaultDeviceButton);
            Controls.Add(label1);
            Controls.Add(PowerUI);
            Controls.Add(Power);
            Name = "Form1";
            Text = "SoundDeviceKeeper";
            Load += FormEvent_Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Power;
        private Label PowerUI;
        private Label label1;
        private Button ChangeDefaultDeviceButton;
        private Label label2;
        private Label CurrentAudioDeviceName;
        private Label label3;
        private Label DefaultAudioDeviceName;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel GitHub;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel UpdateHistory;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
