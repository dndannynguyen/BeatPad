namespace WinFormsApp1
{
    /// <summary>
    /// Bryan Fung
    /// 
    /// Main Form
    /// </summary>
    public partial class BeatPad : Form
    {
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1Filepath != null)
            {
                // call audio player class and call the method play audio
                player.PlayAudio(button1Filepath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2Filepath != null)
            {
                player.PlayAudio(button2Filepath);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3Filepath != null)
            {
                player.PlayAudio(button3Filepath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4Filepath != null)
            {
                player.PlayAudio(button4Filepath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5Filepath != null)
            {
                player.PlayAudio(button5Filepath);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6Filepath != null)
            {
                player.PlayAudio(button6Filepath);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7Filepath != null)
            {
                player.PlayAudio(button7Filepath);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8Filepath != null)
            {
                player.PlayAudio(button8Filepath);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9Filepath != null)
            {
                player.PlayAudio(button9Filepath);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10Filepath != null)
            {
                player.PlayAudio(button10Filepath);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11Filepath != null)
            {
                player.PlayAudio(button11Filepath);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12Filepath != null)
            {
                player.PlayAudio(button12Filepath);
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
    }
}
