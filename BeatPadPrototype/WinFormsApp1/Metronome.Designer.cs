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
            components = new System.ComponentModel.Container();
            hScrollBar1 = new HScrollBar();
            bpmBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(52, 113);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(269, 26);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // bpmBox
            // 
            bpmBox.Location = new Point(117, 68);
            bpmBox.Margin = new Padding(3, 2, 3, 2);
            bpmBox.Name = "bpmBox";
            bpmBox.Size = new Size(117, 23);
            bpmBox.TabIndex = 1;
            bpmBox.Text = "60";
            bpmBox.TextAlign = HorizontalAlignment.Right;
            bpmBox.TextChanged += bpmBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 70);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "bpm";
            // 
            // button1
            // 
            button1.Location = new Point(141, 188);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 3;
            button1.Text = "play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer
            // 
            timer.Tick += TimerTick;
            // 
            // Metronome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 274);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(bpmBox);
            Controls.Add(hScrollBar1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Metronome";
            Text = "Metronome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private TextBox bpmBox;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer;
    }
}