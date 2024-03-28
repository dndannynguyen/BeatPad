namespace WinFormsApp1
{
    partial class Metronome
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
            hScrollBar1 = new HScrollBar();
            bpmBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(59, 151);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(307, 26);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // bpmBox
            // 
            bpmBox.Location = new Point(134, 90);
            bpmBox.Name = "bpmBox";
            bpmBox.Size = new Size(133, 27);
            bpmBox.TabIndex = 1;
            bpmBox.Text = "60";
            bpmBox.TextAlign = HorizontalAlignment.Right;
            bpmBox.TextChanged += bpmBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 93);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "bpm";
            // 
            // button1
            // 
            button1.Location = new Point(161, 251);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 3;
            button1.Text = "play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Metronome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 365);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(bpmBox);
            Controls.Add(hScrollBar1);
            Name = "Metronome";
            Text = "Metronome";
            Load += Metronome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private TextBox bpmBox;
        private Label label1;
        private Button button1;
    }
}