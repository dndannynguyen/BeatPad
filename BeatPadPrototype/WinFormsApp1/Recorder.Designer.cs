namespace WinFormsApp1
{
    partial class Recorder
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
            recordButton = new Button();
            devices = new ComboBox();
            deviceLabel = new Label();
            SuspendLayout();
            // 
            // recordButton
            // 
            recordButton.Location = new Point(75, 115);
            recordButton.Name = "recordButton";
            recordButton.Size = new Size(75, 23);
            recordButton.TabIndex = 0;
            recordButton.Text = "Record";
            recordButton.UseVisualStyleBackColor = true;
            recordButton.Click += recordButton_Click;
            // 
            // devices
            // 
            devices.FormattingEnabled = true;
            devices.Location = new Point(12, 54);
            devices.Name = "devices";
            devices.Size = new Size(206, 23);
            devices.TabIndex = 2;
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.Location = new Point(71, 34);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new Size(84, 15);
            deviceLabel.TabIndex = 3;
            deviceLabel.Text = "Select a device";
            // 
            // Recorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 184);
            Controls.Add(deviceLabel);
            Controls.Add(devices);
            Controls.Add(recordButton);
            Name = "Recorder";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button recordButton;
        private ComboBox devices;
        private Label deviceLabel;
    }
}