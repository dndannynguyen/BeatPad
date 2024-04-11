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

        public Task<TimeSpan> PlayAudio(string filepath)
        {
            var tcs = new TaskCompletionSource<TimeSpan>();
            bool fileExists = File.Exists(filepath); // exceptions

            if (fileExists)
            {
                Task.Run(() =>
                {
                    // initialize output device
                    var outputDevice = new WaveOutEvent();
                    var audioFile = new AudioFileReader(filepath);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // get the total duration of the audio file
                    TimeSpan duration = audioFile.TotalTime;

                    tcs.SetResult(duration);
                });
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("File does not exist");
                tcs.SetResult(TimeSpan.Zero);
            }

            return tcs.Task;
        }



        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
