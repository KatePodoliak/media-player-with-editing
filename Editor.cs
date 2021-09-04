using System;
using System.IO;
using NAudio.Lame;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace audioKP
{
    public class Editor
    {
        /// <summary>
        /// trimming mp3 file
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="outputPath"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static void trimMP3(string inputPath, string outputPath, TimeSpan? begin, TimeSpan? end)
        {
            if (begin.HasValue && end.HasValue && begin > end)
                throw new Exception("Error! End position should be more than start position.");
            else
            {
                using (var reader = new Mp3FileReader(inputPath))
                {
                    using (var writer = File.Create(outputPath))
                    {
                        Mp3Frame frame;
                        while ((frame = reader.ReadNextFrame()) != null)
                        {
                            if (reader.CurrentTime >= begin || !begin.HasValue)
                            {
                                if (reader.CurrentTime <= end || !end.HasValue)
                                    writer.Write(frame.RawData, 0, frame.RawData.Length);
                                else
                                    break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// trimming wav file
        /// </summary>
        /// <param name="inPath"></param>
        /// <param name="outPath"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static void trimWav(string inPath, string outPath, TimeSpan begin, TimeSpan end)
        {
            if (begin > end)
                throw new Exception("Error! End position should be more than start position.");
            else
            {
                using (WaveFileReader reader = new WaveFileReader(inPath))
                {
                    using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                    {
                        int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;
                        int startPos = (int)begin.TotalMilliseconds * bytesPerMillisecond;
                        startPos = startPos - startPos % reader.WaveFormat.BlockAlign;
                        int endBytes = (int)end.TotalMilliseconds * bytesPerMillisecond;
                        endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                        int endPos = (int)reader.Length - endBytes;
                        trimWav(reader, writer, startPos, endPos);
                    }
                }
            }
        }
        
        /// <summary>
        /// writting trimming file
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="writer"></param>
        /// <param name="startPos"></param>
        /// <param name="endPos"></param>
        private static void trimWav(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);
                    if (bytesRead > 0)
                    {
                        writer.WriteData(buffer, 0, bytesRead);
                    }
                }
            }
        }

        /// <summary>
        /// converting mp3 file to wav
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public void mp3ToWav(string inputFile, string outputFile)
        {
            using (Mp3FileReader reader = new Mp3FileReader(inputFile))
            {
                using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                {
                    WaveFileWriter.CreateWaveFile(outputFile, pcmStream);
                }
            }
        }

        /// <summary>
        /// converting wav file to mp3
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public void wavToMP3(string inputFile, string outputFile)
        {
            using (var reader = new AudioFileReader(inputFile))
            {
                using (var writer = new LameMP3FileWriter(outputFile, reader.WaveFormat, LAMEPreset.STANDARD))
                {
                    reader.CopyTo(writer);
                }
            }
        }
        
        /// <summary>
        /// combine two mp3 files to one
        /// </summary>
        /// <param name="inputFiles"></param>
        /// <param name="outputFile"></param>
        public void combineMp3(string[] inputFiles, string outputFile)
        {
            using (var writer = File.Create(outputFile))
            {
                foreach (string file in inputFiles)
                {
                    Mp3FileReader reader = new Mp3FileReader(file);
                    if ((writer.Position == 0) && (reader.Id3v2Tag != null))
                        writer.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                    Mp3Frame frame;
                    while ((frame = reader.ReadNextFrame()) != null)
                        writer.Write(frame.RawData, 0, frame.RawData.Length);
                }
            }
        }

        /// <summary>
        /// resampling file
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="rate"></param>
        public void resampling(string inputFile, string outputFile, int rate)
        {
            using (var reader = new AudioFileReader(inputFile))
            {
                var resampler = new WdlResamplingSampleProvider(reader, rate);
                WaveFileWriter.CreateWaveFile16(outputFile, resampler);
            }
        }

        /// <summary>
        /// converting to mono or stereo file
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="type"></param>
        public void changeType(string inputFile, string outputFile, int type)
        {
            if(type == 1) //to mono
            {
                using (var inputReader = new AudioFileReader(inputFile))
                {
                    var mono = new StereoToMonoSampleProvider(inputReader);
                    WaveFileWriter.CreateWaveFile16(outputFile, mono);
                }
            }
            else //to stereo
            {
                using (var inputReader = new AudioFileReader(inputFile))
                {
                    var stereo = new MonoToStereoSampleProvider(inputReader);
                    WaveFileWriter.CreateWaveFile16(outputFile, stereo);
                }
            }
        }
    }
}
