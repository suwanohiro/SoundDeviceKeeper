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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Power = new Button();
            PowerUI = new Label();
            label1 = new Label();
            ChangeDefaultDeviceButton = new Button();
            label2 = new Label();
            CurrentAudioDeviceName = new Label();
            label3 = new Label();
            DefaultAudioDeviceName = new Label();
            menuStrip1 = new MenuStrip();
            ヘルプToolStripMenuItem = new ToolStripMenuItem();
            GitHub = new ToolStripMenuItem();
            UpdateHistory = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            バージョン情報ToolStripMenuItem = new ToolStripMenuItem();
            createdBySuwanohiroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Power
            // 
            Power.BackColor = Color.FromArgb(0, 120, 212);
            Power.FlatStyle = FlatStyle.Popup;
            Power.ForeColor = Color.White;
            Power.Location = new Point(12, 27);
            Power.Name = "Power";
            Power.Size = new Size(75, 23);
            Power.TabIndex = 0;
            Power.Text = "OFF";
            Power.UseVisualStyleBackColor = false;
            Power.Click += FormEvent_Power_Click;
            // 
            // PowerUI
            // 
            PowerUI.BorderStyle = BorderStyle.FixedSingle;
            PowerUI.ForeColor = Color.White;
            PowerUI.Location = new Point(93, 27);
            PowerUI.Name = "PowerUI";
            PowerUI.Size = new Size(100, 23);
            PowerUI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(260, 18);
            label1.TabIndex = 2;
            label1.Text = "現在のデバイスを規定のデバイスとして設定：";
            // 
            // ChangeDefaultDeviceButton
            // 
            ChangeDefaultDeviceButton.BackColor = Color.FromArgb(0, 120, 212);
            ChangeDefaultDeviceButton.FlatStyle = FlatStyle.Popup;
            ChangeDefaultDeviceButton.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ChangeDefaultDeviceButton.ForeColor = Color.White;
            ChangeDefaultDeviceButton.Location = new Point(278, 78);
            ChangeDefaultDeviceButton.Name = "ChangeDefaultDeviceButton";
            ChangeDefaultDeviceButton.Size = new Size(75, 23);
            ChangeDefaultDeviceButton.TabIndex = 3;
            ChangeDefaultDeviceButton.Text = "セット";
            ChangeDefaultDeviceButton.UseVisualStyleBackColor = false;
            ChangeDefaultDeviceButton.Click += ChangeDefaultDeviceButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(120, 103);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 4;
            label2.Text = "現在の音声出力デバイス：";
            // 
            // CurrentAudioDeviceName
            // 
            CurrentAudioDeviceName.AutoSize = true;
            CurrentAudioDeviceName.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CurrentAudioDeviceName.ForeColor = Color.White;
            CurrentAudioDeviceName.Location = new Point(278, 103);
            CurrentAudioDeviceName.Name = "CurrentAudioDeviceName";
            CurrentAudioDeviceName.Size = new Size(103, 18);
            CurrentAudioDeviceName.TabIndex = 5;
            CurrentAudioDeviceName.Text = "No Audio Device";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 124);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 6;
            label3.Text = "設定中の規定のデバイス：";
            // 
            // DefaultAudioDeviceName
            // 
            DefaultAudioDeviceName.AutoSize = true;
            DefaultAudioDeviceName.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            DefaultAudioDeviceName.ForeColor = Color.White;
            DefaultAudioDeviceName.Location = new Point(278, 124);
            DefaultAudioDeviceName.Name = "DefaultAudioDeviceName";
            DefaultAudioDeviceName.Size = new Size(103, 18);
            DefaultAudioDeviceName.TabIndex = 7;
            DefaultAudioDeviceName.Text = "No Audio Device";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(24, 24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ヘルプToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 26);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // ヘルプToolStripMenuItem
            // 
            ヘルプToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GitHub, UpdateHistory, toolStripSeparator1, バージョン情報ToolStripMenuItem, createdBySuwanohiroToolStripMenuItem });
            ヘルプToolStripMenuItem.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ヘルプToolStripMenuItem.ForeColor = Color.White;
            ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            ヘルプToolStripMenuItem.Size = new Size(56, 22);
            ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // GitHub
            // 
            GitHub.Name = "GitHub";
            GitHub.Size = new Size(210, 22);
            GitHub.Text = "GitHub Repository";
            GitHub.Click += GitHub_Click;
            // 
            // UpdateHistory
            // 
            UpdateHistory.Name = "UpdateHistory";
            UpdateHistory.Size = new Size(210, 22);
            UpdateHistory.Text = "更新履歴";
            UpdateHistory.Click += UpdateHistory_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(207, 6);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            バージョン情報ToolStripMenuItem.Enabled = false;
            バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            バージョン情報ToolStripMenuItem.Size = new Size(210, 22);
            バージョン情報ToolStripMenuItem.Text = "Version 1.00";
            // 
            // createdBySuwanohiroToolStripMenuItem
            // 
            createdBySuwanohiroToolStripMenuItem.Enabled = false;
            createdBySuwanohiroToolStripMenuItem.Name = "createdBySuwanohiroToolStripMenuItem";
            createdBySuwanohiroToolStripMenuItem.Size = new Size(210, 22);
            createdBySuwanohiroToolStripMenuItem.Text = "Created by suwanohiro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(582, 150);
            Controls.Add(menuStrip1);
            Controls.Add(DefaultAudioDeviceName);
            Controls.Add(label3);
            Controls.Add(CurrentAudioDeviceName);
            Controls.Add(label2);
            Controls.Add(ChangeDefaultDeviceButton);
            Controls.Add(label1);
            Controls.Add(PowerUI);
            Controls.Add(Power);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundDeviceKeeper";
            Load += FormEvent_Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private ToolStripMenuItem createdBySuwanohiroToolStripMenuItem;
        private ToolStripMenuItem GitHub;
        private ToolStripMenuItem UpdateHistory;
        private ToolStripSeparator toolStripSeparator1;
    }
}
