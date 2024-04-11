using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// SeungJae Baek
    /// 
    /// Audio Recorder
    /// </summary>
    internal class AudioRecorder
    {
        private WasapiLoopbackCapture? capture;
        private WaveFileWriter? waveFileWriter;

        public Array LoadDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            return devices.ToArray();
        }

        public string GetSaveLocation()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Wave files | *.wav";

            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return "-1";
            }
            return saveDialog.FileName;
        }

        public void StartRecording(string filename, MMDevice device)
        {
            this.capture = new WasapiLoopbackCapture(device);
            this.waveFileWriter = new WaveFileWriter(filename, capture.WaveFormat);
            capture.DataAvailable += (_, @event) =>
            {
                waveFileWriter.Write(@event.Buffer, 0, @event.BytesRecorded);
            };

            capture.RecordingStopped += (_, @event) =>
            {
                waveFileWriter.Dispose();
                capture.Dispose();

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(filename),
                    UseShellExecute = true,
                };
                Process.Start(startInfo);
            };

            capture.StartRecording();
        }

        public void StopRecording()
        {
            if (capture != null)
            {
                capture.StopRecording();
            }
        }
    }
}
