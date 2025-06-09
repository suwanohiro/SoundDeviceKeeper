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
            button1 = new Button();
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
            label1.Size = new Size(208, 15);
            label1.TabIndex = 2;
            label1.Text = "現在のデバイスを規定のデバイスとして設定";
            // 
            // button1
            // 
            button1.Location = new Point(226, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "セット";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(PowerUI);
            Controls.Add(Power);
            Name = "Form1";
            Text = "Form1";
            Load += FormEvent_Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Power;
        private Label PowerUI;
        private Label label1;
        private Button button1;
    }
}
