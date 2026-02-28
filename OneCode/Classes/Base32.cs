using System;
using System.Text;

namespace OneCode.Classes
{
    public static class Base32
    {
        // The alphabet required for Base32
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

        public static string ToBase32(byte[] data)
        {
            if (data == null || data.Length == 0) return string.Empty;

            StringBuilder sb = new StringBuilder();
            int buffer = data[0];
            int next = 1;
            int bitsLeft = 8;

            while (bitsLeft > 0 || next < data.Length)
            {
                if (bitsLeft < 5)
                {
                    if (next < data.Length)
                    {
                        buffer <<= 8;
                        buffer |= data[next++] & 0xFF;
                        bitsLeft += 8;
                    }
                    else
                    {
                        int pad = 5 - bitsLeft;
                        buffer <<= pad;
                        bitsLeft += pad;
                    }
                }

                int index = (buffer >> (bitsLeft - 5)) & 0x1F;
                bitsLeft -= 5;
                sb.Append(Alphabet[index]);
            }

            return sb.ToString();
        }

        public static byte[] FromBase32(string base32)
        {
            if (string.IsNullOrEmpty(base32)) return new byte[0];

            base32 = base32.TrimEnd('=').ToUpperInvariant();
            int byteCount = base32.Length * 5 / 8;
            byte[] result = new byte[byteCount];

            int buffer = 0;
            int bitsLeft = 0;
            int index = 0;

            foreach (char c in base32)
            {
                int val = Alphabet.IndexOf(c);
                if (val < 0) throw new FormatException("Invalid Base32 character: " + c);

                buffer <<= 5;
                buffer |= val & 0x1F;
                bitsLeft += 5;

                if (bitsLeft >= 8)
                {
                    result[index++] = (byte)((buffer >> (bitsLeft - 8)) & 0xFF);
                    bitsLeft -= 8;
                }
            }

            return result;
        }
    }
}