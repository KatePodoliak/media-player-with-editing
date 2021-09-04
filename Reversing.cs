using System;
using System.IO;

namespace audioKP
{
    public class Reversing
    {
        private string input, output;
        private static int bytesInSample;

        public Reversing(string input, string output)
        {
            this.input = input;
            this.output = output;
        }
        /// <summary>
        /// read file’s file stream into a byte array, reverse audio
        /// </summary>
        public void reverse()
        {
            FileStream fsInput = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] inputArray = new byte[fsInput.Length];
            fsInput.Read(inputArray, 0, (int)fsInput.Length);
            bytesInSample = MetaData.getBitsPerSample(inputArray)/8;
            int indexData = getIndexData(inputArray);
            byte[] outputArray = fillByteArray(inputArray, indexData, bytesInSample);
            FileStream fsOutput = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.Write);
            fsOutput.Write(outputArray, 0, outputArray.Length);
        }

        /// <summary>
        /// fill byte array in wav file
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexData"></param>
        /// <param name="bytesPerSample"></param>
        /// <returns></returns>
        private static byte[] fillByteArray(byte[] array, int indexData, int bytesPerSample)
        {
            byte[] inputArrayHeaders = extractHeaders(array, indexData);
            byte[] inputArrayAudioData = extractAudio(array, indexData);
            byte[] outputArrayAudioData = reverseData(bytesPerSample, inputArrayAudioData);
            byte[] outputWavFile = combineArrays(inputArrayHeaders, outputArrayAudioData);
            return outputWavFile;
        }

        /// <summary>
        /// extract audio from byte array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexData"></param>
        /// <returns></returns>
        private static byte[] extractAudio(byte[] array, int indexData)
        {
            byte[] arrayAudio = new byte[array.Length - indexData];
            Array.Copy(array, indexData, arrayAudio, 0, array.Length - indexData);
            return arrayAudio;
        }

        /// <summary>
        /// extract headers from byte array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexData"></param>
        /// <returns></returns>
        private static byte[] extractHeaders(byte[] array, int indexData)
        {
            byte[] arrayHeaders = new byte[indexData];
            Array.Copy(array, 0, arrayHeaders, 0, indexData);
            return arrayHeaders;
        }

        /// <summary>
        /// reversing samples
        /// </summary>
        /// <param name="bytesPerSample"></param>
        /// <param name="inputArrayAudioData"></param>
        /// <returns></returns>
        private static byte[] reverseData(int bytesPerSample, byte[] inputArrayAudioData)
        {
            int length = inputArrayAudioData.Length;
            byte[] outputArrayAudioData = new byte[length];
            int sampleIdentifier = 0;
            for (int i = 0; i < length; i++)
            {
                if (i != 0 && i % bytesPerSample == 0)
                    sampleIdentifier += 2 * bytesPerSample;
                int k = length - bytesPerSample - sampleIdentifier + i;
                outputArrayAudioData[i] = inputArrayAudioData[k];
            }
            return outputArrayAudioData;
        }

        /// <summary>
        /// copy in header bytes and reversed samples
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="outputArray"></param>
        /// <returns></returns>
        private static byte[] combineArrays(byte[] inputArray, byte[] outputArray)
        {
            byte[] outputWavFile = new byte[inputArray.Length + outputArray.Length];
            Array.Copy(inputArray, outputWavFile, inputArray.Length);
            Array.Copy(outputArray, 0, outputWavFile, inputArray.Length, outputArray.Length);
            return outputWavFile;
        }

        /// <summary>
        /// get start index od audio data
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int getIndexData(byte[] array)
        {
            int indexAudio = 12;
            int decimalDascii = 100; //'d' 
            int decimalAascii = 97;  //'a'
            int decimalTascii = 116; //'t'
            int size;
            while (!(array[indexAudio] == decimalDascii && array[indexAudio + 1] == decimalAascii && array[indexAudio + 2] == decimalTascii && array[indexAudio + 3] == decimalAascii))
            {
                indexAudio += 4;
                size = array[indexAudio] + array[indexAudio + 1] * 256 + array[indexAudio + 2] * 65536 + array[indexAudio + 3] * 16777216;
                indexAudio += 4 + size;
            }
            indexAudio += 8;
            return indexAudio;
        }
    }
}
