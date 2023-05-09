using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mentoring_system.implementation
{
    public class UIConfig
    {
            public Config config { get; set; }
            public const String filePath = @"C:\projects\JSON\config.json";
        public UIConfig()
            {
                try
                {
                Console.WriteLine("check");
                ReadConfigFile();
                }
                catch (Exception)
                {
                    SetDefault();
                Console.WriteLine(config.Height);
                Console.WriteLine(config.Width);
                Console.WriteLine("check");
                    WriteNewConfigFile();
                }
            }
            private Config ReadConfigFile()
            {
                String configJsonData = File.ReadAllText(filePath);
                config = JsonSerializer.Deserialize<Config>(configJsonData);
                return config;
            }
            private void SetDefault()
            {
                config = new Config();
                this.config.Height = 754;
                this.config.Width = 539;

            }
            private void WriteNewConfigFile()
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                String jsonString = JsonSerializer.Serialize(config, options);
                File.WriteAllText(filePath, jsonString);
            }

    }

    public class Config 
    {
        //Attribute untuk diserialisasi
        public int Height { get; set; }
        public int Width { get; set; }
        //Constructor kosong untuk deserialisasi
        public Config() { }
        public Config(int width, int height)
        {
            Height = height;
            Width = width;
        }
    }
}