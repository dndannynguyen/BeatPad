using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Recorder : Form
    {
        private AudioRecorder recorder;
        private Array listOfDevices;

        public Recorder()
        {
            InitializeComponent();
            this.recorder = new AudioRecorder();
            this.listOfDevices = this.recorder.LoadDevices();
            devices.Items.AddRange((object[])this.listOfDevices);
            devices.SelectedIndex = 0;
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (recordButton.Text == "Record")
            {
                string filename = this.recorder.GetSaveLocation();
                this.recorder.StartRecording(filename, (MMDevice)devices.SelectedItem);
                recordButton.Text = "Stop";
            }
            else if (recordButton.Text == "Stop")
            {
                this.recorder.StopRecording();
                recordButton.Text = "Record";
            }
        }

        private void recordFileNameTextBox_Click(object sender, EventArgs e)
        {

        }

    }
}

