using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AudioPlayer
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader? audioFile;

        public AudioPlayer()
        {
            // initialize output device
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
        }

        public void PlayAudio(string filepath)
        {
            bool fileExists = File.Exists(filepath);
            if (fileExists)
            {
                audioFile = new AudioFileReader(filepath);
                outputDevice.Init(audioFile);
                outputDevice.Play(); 
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("File does not exist");
            }

        }
    }
}
