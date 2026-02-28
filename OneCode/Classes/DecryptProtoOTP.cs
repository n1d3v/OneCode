// This is a reverse engineered system of the otpauth-migration:// URL
// This is used when migrating codes from Google Authenticator.

using System;
using System.Collections.Generic;

namespace OneCode.Classes
{
    public class DecryptProtoOTP
    {
        // This is the prefix Google uses in their QR code system.
        private const string Prefix = "otpauth-migration://offline?data=";

        public static List<OtpResult> ParseOTPString(string input)
        {
            // First we remove the prefix from the data to get our data
            string base64 = RemoveOTPPrefix(input);

            // We then convert the string into raw binary so Protobuf can read the dat
            byte[] payloadBytes =
                Convert.FromBase64String(Uri.UnescapeDataString(base64));

            // We deserialize the data into C# payloads
            MigrationPayload payload =
                MigrationPayload.Parser.ParseFrom(payloadBytes);

            // Return a list of results from the decrypted string
            var results = new List<OtpResult>();
            foreach (var entry in payload.OtpParameters)
            {
                int digits = entry.Digits == 2 ? 8 : 6;

                // Define our algorithm for TOTP.
                int algorithm;
                if (entry.Algorithm == 2) algorithm = 2; else if (entry.Algorithm == 3) algorithm = 3; else algorithm = 1;

                results.Add(new OtpResult
                {
                    Issuer = entry.Issuer,
                    Name = entry.Name,
                    Secret = Base32.ToBase32(entry.Secret.ToByteArray()),
                });
            }

            return results;
        }

        public static string RemoveOTPPrefix(string input)
        {
            // Removes the otpauth-migration://offline?data= prefix that Google uses.
            if (input.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
                return input.Substring(Prefix.Length);

            return input;
        }
    }

    public class OtpResult
    {
        public string Issuer { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
    }
}