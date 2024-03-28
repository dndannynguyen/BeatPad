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

        private void button1_Click(object sender, EventArgs e)
        {
            // if bpmBox text is more than lower limit or less than upper limit
            if (LowerLimit <= int.Parse(bpmBox.Text) && int.Parse(bpmBox.Text) <= UpperLimit)
            {
                bpm = int.Parse(bpmBox.Text);
            }
            else
            {
                bpm = int.Parse(bpmBox.Text) > UpperLimit ? UpperLimit : LowerLimit;
            }
            bpmBox.Text = bpm.ToString();
            PlayMetronome();
        }

        private void bpmBox_TextChanged(object sender, EventArgs e)
        {
            bool isNumerical = int.TryParse(bpmBox.Text, out int Int);
            if (!isNumerical)
            {
                bpmBox.Text = "60";
            }
            bpm = int.Parse(bpmBox.Text);
            SetScrollBar(bpm);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int bpmUpperRange = UpperLimit - LowerLimit;
            float maxScrollValue = 91f;
            float scrollValue = hScrollBar1.Value / maxScrollValue;
            int finalBpm = (int) (LowerLimit + (bpmUpperRange * scrollValue));
            bpmBox.Text = finalBpm.ToString();
        }

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

        public void StartTimer(int interval)
        {
            timer.Interval = interval;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            string filepath = GetAudioDirectory() + $"/metronome/tick.mp3";
            player.PlayAudio(filepath);
        }

        private void PlayMetronome()
        {
            float bps = bpm / 60f;
            int spb = (int)((1 / bps) * 1000f);
            StartTimer(spb);
        }

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
