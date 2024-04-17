// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

public class program
{
    public class config
    {
        public string language { get; set; }
        public transfer_ transfer { get; set; }
        public object methods {  get; set; }
        public confirmation confirmations {  get; set; }


        public config() { }

        public config(string lang, transfer_ transf, confirmation confirm)
        {
            language = lang;
            transfer = transf;
            confirmations = confirm;


        }

        public config(string v1, int v2, int v3, int v4, object value, string v5, string v6)
        {
        }

        public config(string v1, int v2, int v3, int v4, string v5, string v6)
        {
        }
        public class transfer_
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public class confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }
    }


    public class bankTransferConfig
    {
        public config configuration;

        public const string filePath = "D:\\r\\modul8_1302223010\\modul8_1302223010\\bank_transfer_config.json";

        public bankTransferConfig()

        {
            try
            {
                readConfigFile();
            }
            catch(Exception) {
                setDefault();
                writeNewConfigFile();
            }
        }
        private config readConfigFile()
        {
            string configJsonData = File.ReadAllText(filePath);
            configuration = JsonSerializer.Deserialize<config>(configJsonData);
            return configuration;
        }

        public void writeNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(configuration, options);
            File.WriteAllText(filePath, jsonString);
        }
        public void setDefault()
        {
            //object value = ["RTO(nreal-time)", "SKN", "RTGS", "BI FAST"];
            configuration = new config("en", 25000000, 6500, 15000, "yes", "ya");
        }
    }

    public static void Main(string[] args)
    {
        bankTransferConfig konfig = new bankTransferConfig();

        

        Console.WriteLine("Choose your language : en/id" + konfig.configuration.language);
        string inputLang = Convert.ToString(Console.ReadLine());

        if (inputLang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer" + konfig.configuration.language);
            int thres = Convert.ToInt32(Console.ReadLine());
            //if (konfig.configuration.transfer >= thres)
            {

            }
        }
        else if (inputLang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer" + konfig.configuration.language);
            int thres = Convert.ToInt32(Console.ReadLine());
        }

    }
    
}