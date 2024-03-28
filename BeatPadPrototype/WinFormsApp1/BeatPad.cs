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
        private void upload1_Click(object sender, EventArgs e)
        {
            // reset upload form
            uploadForm.resetForm();
            // show the upload form
            uploadForm.ShowDialog();

            // if user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // add the audio file path of button 1
                this.button1Filepath = uploadForm.filepath;
                // enable button 1
                button1.Enabled = true;
                // change the button name if user added a name
                if (upload1.Name != null)
                {
                    button1.Text = uploadForm.name;
                }
                else
                {
                    button1.Text = "Button";
                }
            }
        }

        private void upload2_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button2Filepath = uploadForm.filepath;
                button2.Enabled = true;
                if (upload2.Name != null)
                {
                    button2.Text = uploadForm.name;
                }
                else
                {
                    button2.Text = "Button";
                }
            }
        }

        private void upload3_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button3Filepath = uploadForm.filepath;
                button3.Enabled = true;
                if (upload3.Name != null)
                {
                    button3.Text = uploadForm.name;
                }
                else
                {
                    button3.Text = "Button";
                }
            }
        }

        private void upload4_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button4Filepath = uploadForm.filepath;
                button4.Enabled = true;
                if (upload4.Name != null)
                {
                    button4.Text = uploadForm.name;
                }
                else
                {
                    button4.Text = "Button";
                }
            }
        }

        private void upload5_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button5Filepath = uploadForm.filepath;
                button5.Enabled = true;
                if (upload5.Name != null)
                {
                    button5.Text = uploadForm.name;
                }
                else
                {
                    button5.Text = "Button";
                }
            }

        }

        private void upload6_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button6Filepath = uploadForm.filepath;
                button6.Enabled = true;
                if (upload6.Name != null)
                {
                    button6.Text = uploadForm.name;
                }
                else
                {
                    button6.Text = "Button";
                }
            }
        }

        private void upload7_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button7Filepath = uploadForm.filepath;
                button7.Enabled = true;
                if (upload7.Name != null)
                {
                    button7.Text = uploadForm.name;
                }
                else
                {
                    button7.Text = "Button";
                }
            }
        }

        private void upload8_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button8Filepath = uploadForm.filepath;
                button8.Enabled = true;
                if (upload8.Name != null)
                {
                    button8.Text = uploadForm.name;
                }
                else
                {
                    button8.Text = "Button";
                }
            }
        }

        private void upload9_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button9Filepath = uploadForm.filepath;
                button9.Enabled = true;
                if (upload9.Name != null)
                {
                    button9.Text = uploadForm.name;
                }
                else
                {
                    button9.Text = "Button";
                }
            }
        }

        private void upload10_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button10Filepath = uploadForm.filepath;
                button10.Enabled = true;
                if (upload10.Name != null)
                {
                    button10.Text = uploadForm.name;
                }
                else
                {
                    button10.Text = "Button";
                }
            }
        }
        private void upload11_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button11Filepath = uploadForm.filepath;
                button11.Enabled = true;
                if (upload11.Name != null)
                {
                    button11.Text = uploadForm.name;
                }
                else
                {
                    button11.Text = "Button";
                }
            }
        }
        private void upload12_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filepath != null)
            {
                this.button12Filepath = uploadForm.filepath;
                button12.Enabled = true;
                if (upload12.Name != null)
                {
                    button12.Text = uploadForm.name;
                }
                else
                {
                    button12.Text = "Button";
                }
            }
        }

        private void BeatPad_Load(object sender, EventArgs e)
        {

        }
    }
}
