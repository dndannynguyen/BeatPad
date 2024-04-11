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

        /// <summary>
        /// Loads Devices and returns the list of active audio devices
        /// </summary>
        /// <returns></returns>
        public Array LoadDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            return devices.ToArray();
        }

        /// <summary>
        /// Opens SaveFileDialog and returns the filename the user provided
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Records audio from the MMDevice given at the place of filename
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="device"></param>
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

        /// <summary>
        /// Calls capture stop recording
        /// </summary>
        public void StopRecording()
        {
            if (capture != null)
            {
                capture.StopRecording();
            }
        }
    }
}
