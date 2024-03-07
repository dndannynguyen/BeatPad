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
    }
}
