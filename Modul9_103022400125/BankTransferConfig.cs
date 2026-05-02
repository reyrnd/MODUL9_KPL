using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400125
{
    internal class BankTransferConfig
    {
        public Config config { get; set; }
        private string filepath = "D:\\New folder\\Modul9_103022400125\\Modul9_103022400125\\bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
                Console.WriteLine("[INFO] File konfigurasi berhasil dibaca.");
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            string configJsonData = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(configJsonData);
        }

        public void SetDefault()
        {
            config = new Config {
                lang = "en",
                transfer = new Transfer{
                    threshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000
                },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation
                {
                    en = "yes",
                    id = "ya"
                }
            };
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);
        }
    }
}
