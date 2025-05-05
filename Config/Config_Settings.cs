using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class Config_Settings
    {
        public static string Server = "";
        public static string Database = "";
        public static string Username = "";
        public static string Password = "";
        public static string Authen = "sql";

        public static void LoadConfig(string path)
        {   
            if (System.IO.File.Exists(path))
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines.Length < 5)
                {
                    throw new Exception("Config file is not valid. Please check the format.");
                }

                if (lines.Length >= 5)
                {  
                    Server = lines[0].Trim();
                    Database = lines[1].Trim();
                    Username = lines[2].Trim();
                    Password = lines[3].Trim();
                    Authen = lines[4].Trim().ToLower();
                }
            }
        }
    }
}
