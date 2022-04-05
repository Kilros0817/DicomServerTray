using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DicomServerTray
{

    public static class utility
    {
        public static env CONFIG = new env();
        public static string PATH_CONFIG = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        public static void Config()
        {
            string envJson = string.Empty;
            if (File.Exists(PATH_CONFIG))
            {
                envJson = File.ReadAllText(PATH_CONFIG);
                CONFIG = JsonConvert.DeserializeObject<env>(envJson);
            }
            else
            {
                WriteConfig();
            }

            for (int i = 1; i < 4; i++)
            {
                string path = Path.Combine(CONFIG.PATH_LOG, $"log{i}.txt");
                if (!File.Exists(path))
                    File.Create(path);
            }
            if (!Directory.Exists(CONFIG.PATH_JPG))
                Directory.CreateDirectory(CONFIG.PATH_JPG);
            if (!Directory.Exists(CONFIG.PATH_JPG_Processed))
                Directory.CreateDirectory(CONFIG.PATH_JPG_Processed);
            if (!Directory.Exists(CONFIG.PATH_DCM))
                Directory.CreateDirectory(CONFIG.PATH_DCM);
            if (!Directory.Exists(CONFIG.PATH_DCM_Processed))
                Directory.CreateDirectory(CONFIG.PATH_DCM_Processed);
        }
        public static void WriteConfig()
        {
            string envJson = JsonConvert.SerializeObject(CONFIG, Formatting.Indented);
            File.WriteAllText(PATH_CONFIG, envJson);
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public static bool IsFileOpen(string path)
        {
            bool flag = false;

            Process[] processes = Process.GetProcessesByName("notepad");
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].MainWindowTitle.Equals($"{Path.GetFileName(path)} - Notepad"))
                {
                    BringProcessToFront(processes[i]);
                    flag = true;
                }
            }
            return flag;
        }
        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            SetForegroundWindow(handle);
        }


        public static bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("DicomServerTray") == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }
    }

}
