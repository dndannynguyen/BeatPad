using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class BeatSoundUpload : Form
    {
        public static int AudioCount = 0;
        public String? filename { get; set; }
        public String? name { get; set; }

        public BeatSoundUpload()
        {
            InitializeComponent();
        }

        private void uploadAudioButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            getAudioDirectory();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.filename = fileDialog.FileName;
                uploadText.Text = this.filename;
                buttonNameSubmit.Enabled = true;
            }

        }

        private void buttonNameSubmit_Click(object sender, EventArgs e)
        {
            if (this.filename != null)
            {
                // get the AudioFolder directory and add the audio file name which will be the value of AudioCount
                String destination = getAudioDirectory() + $"/Audio{AudioCount}.mp3";
                // Copy the file to AudioFolder 
                File.Copy(this.filename, destination, true);
                // Replace filename to the destination file
                this.filename = destination;
                // increment AudioCount
                AudioCount++;
                // change name to the input box 
                this.name = buttonNameBox.Text;
                this.Close();
            }
        }

        public void resetForm()
        {
            buttonNameBox.Text = string.Empty;
            uploadText.Text = string.Empty;
        }

        public string getAudioDirectory()
        {
            string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
            int index = rootDirectory.IndexOf("BeatPadPrototype");
            string audioFolderDir = rootDirectory.Substring(0, index + "BeatPadPrototype".Length);
            audioFolderDir = Path.Combine(audioFolderDir, "AudioFolder");
            return audioFolderDir;
        }

        private void BeatSoundUpload_Load(object sender, EventArgs e)
        {
        }
    }
}
