using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    /// <summary>
    /// Bryan Fung
    /// 
    /// Main Form
    /// </summary>
    public partial class BeatPad : Form
    {
        Recorder recorder = new Recorder();
        BeatSoundUpload uploadForm = new BeatSoundUpload(); // upload form
        AudioPlayer player; // audio player class

        String button1Filepath; // file path for button1... etc
        String button2Filepath;
        String button3Filepath;
        String button4Filepath;
        String button5Filepath;
        String button6Filepath;
        String button7Filepath;
        String button8Filepath;
        String button9Filepath;
        String button10Filepath;
        String button11Filepath;
        String button12Filepath;

        public BeatPad()
        {
            InitializeComponent();
            this.player = new AudioPlayer(); // create a new instance of audio player
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1Filepath != null)
            {
                // call audio player class and call the method play audio
                TimeSpan duration = await player.PlayAudio(button1Filepath);

                // create a timer
                Timer timer = new Timer();
                timer.Interval = 100;

                // define the colors to cycle through
                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button1.BackColor;

                // create a tick count
                int tickCount = 0;

                // define the timer tick event
                timer.Tick += (s, ev) =>
                {
                    // Use Invoke to ensure the UI update happens on the main thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Cycle through the colors
                        button1.BackColor = colors[tickCount % colors.Count];

                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();

                            // revert the button's color to its default
                            button1.BackColor = defaultColor;
                        }
                    });
                };

                // start the timer
                timer.Start();
            }
        }






        private async void button2_Click(object sender, EventArgs e)
        {
            if (button2Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button2Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button2.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button2.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button2.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (button3Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button3Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button3.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button3.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button3.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (button4Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button4Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button4.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button4.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button4.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (button5Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button5Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button5.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button5.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button5.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (button6Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button6Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button6.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button6.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button6.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (button7Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button7Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button7.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button7.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button7.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            if (button8Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button8Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button8.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button8.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button8.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (button9Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button9Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button9.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button9.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button9.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }
        private async void button10_Click(object sender, EventArgs e)
        {
            if (button10Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button10Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button10.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button10.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button10.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }
        private async void button11_Click(object sender, EventArgs e)
        {
            if (button11Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button11Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button11.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button11.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button11.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            if (button12Filepath != null)
            {
                TimeSpan duration = await player.PlayAudio(button12Filepath);

                Timer timer = new Timer();
                timer.Interval = 100;

                List<Color> colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                Color defaultColor = button12.BackColor;

                int tickCount = 0;

                timer.Tick += (s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button12.BackColor = colors[tickCount % colors.Count];
                        tickCount++;

                        if (timer.Interval * tickCount >= duration.TotalMilliseconds)
                        {
                            timer.Stop();
                            timer.Dispose();
                            button12.BackColor = defaultColor;
                        }
                    });
                };

                timer.Start();
            }
        }
        private String UploadButtonClickEvent(Button button, Button uploadButton)
        {
            // reset upload form
            uploadForm.resetForm();
            // show the upload form
            uploadForm.ShowDialog();

            // if user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // add the audio file path of button 1
                button.Enabled = true;

                // enable button 1
                if (uploadButton.Name != null)
                {
                    // change the button name if user added a name
                    button.Text = uploadForm.name;
                }
                else
                {
                    // if user did not add a name, default to Button
                    button.Text = "Button";
                }
                return uploadForm.filepath;
            }
            return "null";
        }

        private void upload1_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button1, upload1);
            if (filepath != "null")
            {
                this.button1Filepath = filepath;
            }
        }

        private void upload2_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button2, upload2);
            if (filepath != "null")
            {
                this.button2Filepath = filepath;
            }
        }

        private void upload3_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button3, upload3);
            if (filepath != "null")
            {
                this.button3Filepath = filepath;
            }
        }

        private void metronomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metronome metronome = new Metronome();
            metronome.Show();
        }

        private void upload4_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button4, upload4);
            if (filepath != "null")
            {
                this.button4Filepath = filepath;
            }
        }

        private void upload5_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button5, upload5);
            if (filepath != "null")
            {
                this.button5Filepath = filepath;
            }
        }

        private void upload6_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button6, upload6);
            if (filepath != "null")
            {
                this.button6Filepath = filepath;
            }
        }

        private void upload7_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button7, upload7);
            if (filepath != "null")
            {
                this.button7Filepath = filepath;
            }
        }

        private void upload8_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button8, upload8);
            if (filepath != "null")
            {
                this.button8Filepath = filepath;
            }
        }

        private void upload9_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button9, upload9);
            if (filepath != "null")
            {
                this.button9Filepath = filepath;
            }
        }

        private void upload10_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button10, upload10);
            if (filepath != "null")
            {
                this.button10Filepath = filepath;
            }
        }
        private void upload11_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button11, upload11);
            if (filepath != "null")
            {
                this.button11Filepath = filepath;
            }
        }
        private void upload12_Click(object sender, EventArgs e)
        {
            String filepath = UploadButtonClickEvent(button12, upload12);
            if (filepath != "null")
            {
                this.button12Filepath = filepath;
            }
        }

        private void BeatPad_Load(object sender, EventArgs e)
        {

        }

        private void beatFormatterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FourBar fourBar = new FourBar();
            fourBar.Show();
        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recorder.Show();
        }
    }
}
