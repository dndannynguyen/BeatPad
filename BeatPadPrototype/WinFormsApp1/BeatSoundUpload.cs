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
        public static int AudioCount = 0; // used for audio file name when copied
        public String? filepath { get; set; }
        public String? name { get; set; }

        public BeatSoundUpload()
        {
            InitializeComponent();
        }

        private void uploadAudioButton_Click(object sender, EventArgs e)
        {
            // creates an instance of fileDialog 
            OpenFileDialog fileDialog = new OpenFileDialog();

            // show the dialog and if a file is added,
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Debug.Write("Result == OK");
                // get the filepath of file added
                this.filepath = fileDialog.FileName;
                // add the filepath to the window
                uploadText.Text = this.filepath;
                // enable the submit button
                buttonNameSubmit.Enabled = true;
            }

        }

        private void buttonNameSubmit_Click(object sender, EventArgs e)
        {
            if (this.filepath != null)
            {
                // get the AudioFolder directory and add the audio file name
                String destination = getAudioDirectory() + $"/Audio{AudioCount}.mp3";
                // Copy the uploaded audio file to AudioFolder 
                File.Copy(this.filepath, destination, true);
                // Replace filepath to the audio folder filepath
                this.filepath = destination;
                // increment AudioCount
                AudioCount++;
                // change button name to user input
                this.name = buttonNameBox.Text;
                // close the tab
                this.Close();
            }
        }

        public void resetForm()
        {
            // disable the submit button
            buttonNameSubmit.Enabled = false;
            buttonNameBox.Text = string.Empty;
            uploadText.Text = string.Empty;
        }

        public string getAudioDirectory()
        {
            // get the audio folder path
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
