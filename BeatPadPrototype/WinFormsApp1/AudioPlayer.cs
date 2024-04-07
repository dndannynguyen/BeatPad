using NAudio.Wave;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// SeungJae Baek
    /// 
    /// AudioPlayer Class
    /// Plays audio
    /// </summary>
    internal class AudioPlayer
    {
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void PlayAudio(string filepath)
        {
            bool fileExists = File.Exists(filepath); // excedpgions
            if (fileExists)
            {
                Task.Run(() =>
                {
                    // initialize output device
                    var outputDevice = new WaveOutEvent();
                    var audioFile = new AudioFileReader(filepath);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                });
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("File does not exist");
            }
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
