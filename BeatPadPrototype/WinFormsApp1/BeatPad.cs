namespace WinFormsApp1
{
    public partial class BeatPad : Form
    {
        BeatSoundUpload uploadForm = new BeatSoundUpload();
        AudioPlayer player;
        AudioPlayer player2;

        String button1Filename;
        String button2Filename;
        String button3Filename;
        public BeatPad()
        {
            InitializeComponent();
            this.player = new AudioPlayer();
            this.player2 = new AudioPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1Filename != null)
            {
                player.PlayAudio(button1Filename);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2Filename != null)
            {
                player2.PlayAudio(button2Filename);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3Filename != null)
            {
                player.PlayAudio(button3Filename);
            }
        }

        private void upload1_Click(object sender, EventArgs e)
        {
            uploadForm.resetForm();
            uploadForm.ShowDialog();
            if (uploadForm.filename != null)
            {
                this.button1Filename = uploadForm.filename;
                button1.Enabled = true;
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
            if (uploadForm.filename != null)
            {
                this.button2Filename = uploadForm.filename;
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
            if (uploadForm.filename != null)
            {
                this.button3Filename = uploadForm.filename;
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
