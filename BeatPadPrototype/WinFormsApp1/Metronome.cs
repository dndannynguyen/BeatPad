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
using NAudio;

namespace WinFormsApp1
{
    /// <summary>
    /// SeungJae Baek
    /// 
    /// Metronome
    /// </summary>
    public partial class Metronome : Form
    {
        private const int UpperLimit = 400;
        private const int LowerLimit = 20;
        private int bpm = 60;

        private AudioPlayer player = new AudioPlayer();

        public Metronome()
        {
            InitializeComponent();
            bpmBox.Text = bpm.ToString();
            SetScrollBar(bpm);
        }

        /// <summary>
        /// When play button is clicked, it checks for valid bpm and starts the metronome
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metronomePlay_Click(object sender, EventArgs e)
        {
            // if bpmBox text is more than lower limit or less than upper limit
            if (metronomePlay.Text == "Play")
            {
                if (LowerLimit <= int.Parse(bpmBox.Text) && int.Parse(bpmBox.Text) <= UpperLimit)
                {
                    this.bpm = int.Parse(bpmBox.Text);
                }
                else
                {
                    this.bpm = int.Parse(bpmBox.Text) > UpperLimit ? UpperLimit : LowerLimit;
                }
                bpmBox.Text = this.bpm.ToString();
                PlayMetronome();
                metronomePlay.Text = "Stop";
            }
            else
            {
                metronomePlay.Text = "Play";
                StopMetronome();
            }
        }

        /// <summary>
        /// checks if input is numerical and updates bpm attribute
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bpmBox_TextChanged(object sender, EventArgs e)
        {
            bool isNumerical = int.TryParse(bpmBox.Text, out int Int);
            if (!isNumerical)
            {
                bpmBox.Text = "60";
            }
            this.bpm = int.Parse(bpmBox.Text);
            SetScrollBar(this.bpm);
        }

        /// <summary>
        /// When scroll bar is scrolled, update the bpmBox text
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int bpmUpperRange = UpperLimit - LowerLimit;
            float maxScrollValue = 91f;
            float scrollValue = hScrollBar1.Value / maxScrollValue;
            int finalBpm = (int) (LowerLimit + (bpmUpperRange * scrollValue));
            bpmBox.Text = finalBpm.ToString();
        }

        /// <summary>
        /// Set the scroll bar to a certain value depending on the bpm
        /// 
        /// </summary>
        /// <param name="bpm"></param>
        private void SetScrollBar(int bpm)
        {
            int bpmUpperRange = UpperLimit - LowerLimit;
            float bpmRatio = (float) bpm / bpmUpperRange;
            float scrollValue = bpmRatio * 91f;
            if (scrollValue <= 100)
            {
                hScrollBar1.Value = (int) scrollValue;
            }
            else
            {
                hScrollBar1.Value = 100;
            }
        }

        /// <summary>
        /// Start timer
        /// 
        /// </summary>
        /// <param name="interval"></param>
        public void StartTimer(int interval)
        {
            timer.Interval = interval;
            timer.Start();
        }

        /// <summary>
        /// Play metronome tick
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            string filepath = GetAudioDirectory() + $"/metronome/tick.mp3";
            player.PlayAudio(filepath);
        }

        /// <summary>
        /// Starts the metronome
        /// 
        /// </summary>
        private void PlayMetronome()
        {
            float bps = this.bpm / 60f;
            int spb = (int)((1 / bps) * 1000f);
            StartTimer(spb);
        }

        private void StopMetronome()
        {
            timer.Stop();
        }

        /// <summary>
        /// Create base audio directory filepath string and return it
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetAudioDirectory()
        {
            // get the audio folder path
            string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
            int index = rootDirectory.IndexOf("BeatPadPrototype");
            string audioFolderDir = rootDirectory.Substring(0, index + "BeatPadPrototype".Length);
            audioFolderDir = Path.Combine(audioFolderDir, "AudioFolder");
            return audioFolderDir;
        }
    }
}
