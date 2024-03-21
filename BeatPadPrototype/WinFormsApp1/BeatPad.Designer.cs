namespace WinFormsApp1
{
    partial class BeatPad
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            upload1 = new Button();
            upload2 = new Button();
            upload3 = new Button();
            menuStrip1 = new MenuStrip();
            additionToolStripMenuItem = new ToolStripMenuItem();
            metronomeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(174, 171);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 91);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(382, 171);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 91);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(598, 171);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 91);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // upload1
            // 
            upload1.AccessibleName = "upload1";
            upload1.Location = new Point(174, 269);
            upload1.Margin = new Padding(3, 4, 3, 4);
            upload1.Name = "upload1";
            upload1.Size = new Size(94, 31);
            upload1.TabIndex = 3;
            upload1.Text = "upload";
            upload1.UseVisualStyleBackColor = true;
            upload1.Click += upload1_Click;
            // 
            // upload2
            // 
            upload2.AccessibleName = "upload2";
            upload2.Location = new Point(382, 269);
            upload2.Margin = new Padding(3, 4, 3, 4);
            upload2.Name = "upload2";
            upload2.Size = new Size(94, 31);
            upload2.TabIndex = 4;
            upload2.Text = "upload";
            upload2.UseVisualStyleBackColor = true;
            upload2.Click += upload2_Click;
            // 
            // upload3
            // 
            upload3.AccessibleName = "upload3";
            upload3.Location = new Point(598, 269);
            upload3.Margin = new Padding(3, 4, 3, 4);
            upload3.Name = "upload3";
            upload3.Size = new Size(94, 31);
            upload3.TabIndex = 5;
            upload3.Text = "upload";
            upload3.UseVisualStyleBackColor = true;
            upload3.Click += upload3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { additionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // additionToolStripMenuItem
            // 
            additionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { metronomeToolStripMenuItem });
            additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            additionToolStripMenuItem.Size = new Size(81, 24);
            additionToolStripMenuItem.Text = "Addition";
            // 
            // metronomeToolStripMenuItem
            // 
            metronomeToolStripMenuItem.Name = "metronomeToolStripMenuItem";
            metronomeToolStripMenuItem.Size = new Size(224, 26);
            metronomeToolStripMenuItem.Text = "Metronome";
            metronomeToolStripMenuItem.Click += metronomeToolStripMenuItem_Click;
            // 
            // BeatPad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 697);
            Controls.Add(upload3);
            Controls.Add(upload2);
            Controls.Add(upload1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BeatPad";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button1;
        private Button upload1;
        private Button upload2;
        private Button upload3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem additionToolStripMenuItem;
        private ToolStripMenuItem metronomeToolStripMenuItem;
    }
}
