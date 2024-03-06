namespace WinFormsApp1
{
    partial class BeatSoundUpload
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
            buttonNameBox = new TextBox();
            buttonNameSubmit = new Button();
            label1 = new Label();
            uploadAudioButton = new Button();
            uploadText = new Label();
            SuspendLayout();
            // 
            // buttonNameBox
            // 
            buttonNameBox.Location = new Point(63, 80);
            buttonNameBox.Name = "buttonNameBox";
            buttonNameBox.Size = new Size(295, 23);
            buttonNameBox.TabIndex = 0;
            // 
            // buttonNameSubmit
            // 
            buttonNameSubmit.Enabled = false;
            buttonNameSubmit.Location = new Point(180, 215);
            buttonNameSubmit.Name = "buttonNameSubmit";
            buttonNameSubmit.Size = new Size(53, 37);
            buttonNameSubmit.TabIndex = 1;
            buttonNameSubmit.Text = "Add";
            buttonNameSubmit.UseVisualStyleBackColor = true;
            buttonNameSubmit.Click += buttonNameSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Button Name";
            // 
            // uploadAudioButton
            // 
            uploadAudioButton.Location = new Point(169, 151);
            uploadAudioButton.Name = "uploadAudioButton";
            uploadAudioButton.Size = new Size(75, 23);
            uploadAudioButton.TabIndex = 3;
            uploadAudioButton.Text = "Upload";
            uploadAudioButton.UseVisualStyleBackColor = true;
            uploadAudioButton.Click += uploadAudioButton_Click;
            // 
            // uploadText
            // 
            uploadText.Location = new Point(-2, 127);
            uploadText.Name = "uploadText";
            uploadText.RightToLeft = RightToLeft.No;
            uploadText.Size = new Size(426, 21);
            uploadText.TabIndex = 4;
            uploadText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BeatSoundUpload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 283);
            Controls.Add(uploadText);
            Controls.Add(uploadAudioButton);
            Controls.Add(label1);
            Controls.Add(buttonNameSubmit);
            Controls.Add(buttonNameBox);
            Name = "BeatSoundUpload";
            Text = "BeatSoundUpload";
            Load += BeatSoundUpload_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox buttonNameBox;
        private Button buttonNameSubmit;
        private Label label1;
        private Button uploadAudioButton;
        private Label uploadText;
    }
}