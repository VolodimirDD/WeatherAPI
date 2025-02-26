using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace Weather
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string exePath = Application.ExecutablePath;
            if (exePath.StartsWith(Path.GetTempPath(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please unzip all files before running the program!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string[] requiredFiles = {
                "Newtonsoft.Json.dll",
                "Newtonsoft.Json.xml",
                "System.Configuration.ConfigurationManager.dll",
                "System.Configuration.ConfigurationManager.xml",
                "Weather.exe.config",
                "Weather.pdb"
            };

            var missingFiles = new System.Text.StringBuilder();

            foreach (string file in requiredFiles)
            {
                if (!File.Exists(Path.Combine(baseDir, file)))
                {
                    missingFiles.AppendLine(file); 
                }
            }

            if (missingFiles.Length > 0)
            {
                MessageBox.Show($"Not all files are unpacked! The following files are missing:\n{missingFiles}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsRunAsAdmin() && !IsRunningInVisualStudio())
            {
                RestartAsAdmin();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static bool IsRunAsAdmin()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private static bool IsRunningInVisualStudio()
        {
            return Debugger.IsAttached;
        }

        private static void RestartAsAdmin()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true,
                    Verb = "runas" 
                };

                Process.Start(proc);
            }
            catch
            {
                MessageBox.Show("Failed to run the program with administrator rights!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0);
        }
    }

}

