using NAudio.Utils;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerRecognitionAPI.Services
{
    public class WavAudioRecorder
    {
        private static WaveIn _waveIn;
        private static WaveFileWriter _fileWriter;
        private static Stream _stream;

        private static void initializeRecorder()
        {
            _waveIn = new WaveIn();
            _waveIn.DeviceNumber = 0;
            int sampleRate = 16000; // 16 kHz
            int channels = 1; // mono
            _waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            _waveIn.DataAvailable += waveIn_DataAvailable;
            _waveIn.RecordingStopped += waveSource_RecordingStopped;
        }

        private static void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            _fileWriter.Dispose();
            _fileWriter = null;
            _stream.Seek(0, SeekOrigin.Begin);
            //Dispose recorder object
            _waveIn.Dispose();
            initializeRecorder();
        }

        private static void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (_fileWriter == null)
            {
                _stream = new IgnoreDisposeStream(new MemoryStream());
                _fileWriter = new WaveFileWriter(_stream, _waveIn.WaveFormat);
            }
            _fileWriter.Write(e.Buffer, 0, e.BytesRecorded);
        }

        public static void StartRecording()
        {
            if (WaveIn.DeviceCount == 0)
            {
                throw new Exception("Cannot detect microphone.");
            }

            if (_waveIn == null) initializeRecorder();

            _waveIn.StartRecording();
        }

        public static Stream StopRecording()
        {
            _waveIn.StopRecording();
            return _stream;
        }
    }
}
