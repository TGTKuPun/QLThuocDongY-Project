using Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string configPath = "";
            if (File.Exists(configPath))
            {
                Config_Settings.LoadConfig(configPath);
            }
            else
            {
                Application.Run(new frm_Config());
            }

            Application.Run(new frm_SignIn("", ""));
        }
    }
}
