using System.Security.Cryptography;
using System.Text;

namespace vHackOS.Cryptography
{
    internal class vhCrypto
    {
        private static byte[] encode3to4(byte[] source, int srcOffset, int numSigBytes, byte[] destination, int destOffset, byte[] alphabet)
        {
            int i;
            int i2 = 0;
            if (numSigBytes > 0)
            {
                i = (int)((uint)(source[srcOffset] << 24)) >> 8;
            }
            else
            {
                i = 0;
            }
            int i3 = (numSigBytes > 1 ? (int)((uint)(source[srcOffset + 1] << 24)) >> 16 : 0) | i;
            if (numSigBytes > 2)
            {
                i2 = (int)((uint)(source[srcOffset + 2] << 24)) >> 24;
            }
            int inBuff = i3 | i2;
            switch (numSigBytes)
            {
                case 1:
                    destination[destOffset] = alphabet[(int)((uint)inBuff) >> 18];
                    destination[destOffset + 1] = alphabet[((int)((uint)inBuff) >> 12) & 63];
                    destination[destOffset + 2] = 61;
                    destination[destOffset + 3] = 61;
                    break;
                case 2:
                    destination[destOffset] = alphabet[(int)((uint)inBuff) >> 18];
                    destination[destOffset + 1] = alphabet[((int)((uint)inBuff) >> 12) & 63];
                    destination[destOffset + 2] = alphabet[((int)((uint)inBuff) >> 6) & 63];
                    destination[destOffset + 3] = 61;
                    break;
                case 3:
                    destination[destOffset] = alphabet[(int)((uint)inBuff) >> 18];
                    destination[destOffset + 1] = alphabet[((int)((uint)inBuff) >> 12) & 63];
                    destination[destOffset + 2] = alphabet[((int)((uint)inBuff) >> 6) & 63];
                    destination[destOffset + 3] = alphabet[inBuff & 63];
                    break;
            }
            return destination;
        }

        internal static byte[] encode(byte[] source, int off, int len, byte[] alphabet, int maxLineLength)
        {
            int len43 = ((len + 2) / 3) * 4;
            byte[] outBuff = new byte[((len43 / maxLineLength) + len43)];
            int d = 0;
            int e = 0;
            int len2 = len - 2;
            int lineLength = 0;
            while (d < len2)
            {
                int inBuff = (((int)((uint)(source[d + off] << 24)) >> 8) | ((int)((uint)(source[(d + 1) + off] << 24)) >> 16)) | ((int)((uint)(source[(d + 2) + off] << 24)) >> 24);
                outBuff[e] = alphabet[(int)((uint)inBuff) >> 18];
                outBuff[e + 1] = alphabet[((int)((uint)inBuff) >> 12) & 63];
                outBuff[e + 2] = alphabet[((int)((uint)inBuff) >> 6) & 63];
                outBuff[e + 3] = alphabet[inBuff & 63];
                lineLength += 4;
                if (lineLength == maxLineLength)
                {
                    outBuff[e + 4] = (byte)10;
                    e++;
                    lineLength = 0;
                }
                d += 3;
                e += 4;
            }
            if (d < len)
            {
                encode3to4(source, d + off, len - d, outBuff, e, alphabet);
                if (lineLength + 4 == maxLineLength)
                {
                    outBuff[e + 4] = (byte)10;
                    e++;
                }
                e += 4;
            }
            return outBuff;
        }

        internal static string encode(byte[] source, int off, int len, byte[] alphabet, bool doPadding)
        {
            byte[] outBuff = encode(source, off, len, alphabet, int.MaxValue);
            int outLen = outBuff.Length;
            while (!doPadding && outLen > 0 && outBuff[outLen - 1] == 61)
            {
                outLen--;
            }
            return Encoding.Default.GetString(outBuff, 0, outLen);
        }

        internal static string GetMD5HashString(string str)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(textToHash);
            return System.BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}