using System;

namespace audioKP
{
    class MetaData
    {
        public static int positionBits1 = 34, positionBits2 = 35;
        internal static ushort getBitsPerSample(byte[] array)
        {
            byte[] bitsPerSampleByteArray = getBytesNewArray(array, positionBits1, positionBits2);
            ushort bitsPerSample = BitConverter.ToUInt16(bitsPerSampleByteArray, 0);  
            return bitsPerSample;
        }

        internal static byte[] getBytesNewArray(byte[] array, int startIndex, int endIndex)
        {
            int length = endIndex - startIndex + 1;
            byte[] newArray = new byte[length];
            Array.Copy(array, startIndex, newArray, 0, length);
            return newArray;
        }
    }
}
