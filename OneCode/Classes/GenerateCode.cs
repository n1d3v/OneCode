using System;
using System.Security.Cryptography;

namespace OneCode.Classes
{
    class GenerateCode
    {
        public static string GenerateTOTP(byte[] secret, int digits, int algorithm)
        {
            // Unix time isn't really available in .NET 4.5.2, we have to do it manually.
            long unixTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            long timestep = unixTime / 30;

            byte[] counter = BitConverter.GetBytes(timestep);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(counter);

            byte[] hash;

            switch (algorithm)
            {
                case 2: // 2 = SHA256
                    using (var h = new HMACSHA256(secret))
                        hash = h.ComputeHash(counter);
                    break;

                case 3: // 3 = SHA512
                    using (var h = new HMACSHA512(secret))
                        hash = h.ComputeHash(counter);
                    break;

                default: // 1 = SHA1
                    using (var h = new HMACSHA1(secret))
                        hash = h.ComputeHash(counter);
                    break;
            }

            int offset = hash[hash.Length - 1] & 0x0F;
            int binary =
                ((hash[offset] & 0x7F) << 24) |
                (hash[offset + 1] << 16) |
                (hash[offset + 2] << 8) |
                (hash[offset + 3]);

            int modulus = digits == 8 ? 100_000_000 : 1_000_000;
            int otp = binary % modulus;

            var formatted = otp.ToString().PadLeft(digits, '0');
            if (formatted.Length == 6) { formatted = formatted.Insert(3, " "); }

            return formatted;
        }
    }
}