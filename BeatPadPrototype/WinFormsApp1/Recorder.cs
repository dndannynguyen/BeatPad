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
        /// <summary>
        /// SeungJae Baek
        /// 
        /// Audio Recorder Form
        /// </summary>
        private AudioRecorder recorder;
        private Array listOfDevices;

        /// <summary>
        /// Initializes audio recorder, and sets up for recording
        /// </summary>
        public Recorder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.recorder = new AudioRecorder();
            this.listOfDevices = this.recorder.LoadDevices();
            devices.Items.AddRange((object[])this.listOfDevices);
            devices.SelectedIndex = 0;
        }

        /// <summary>
        /// When record button is clicked, depending on the button text state, it will start recording, or stop
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recordButton_Click(object sender, EventArgs e)
        {
            if (recordButton.Text == "Record")
            {
                string filename = this.recorder.GetSaveLocation();
                this.recorder.StartRecording(filename, (MMDevice)devices.SelectedItem);
                recordButton.Text = "Stop Recording";
            }
            else if (recordButton.Text == "Stop Recording")
            {
                this.recorder.StopRecording();
                recordButton.Text = "Record";
            }
        }
    }
}

