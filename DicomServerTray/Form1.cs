using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace DicomServerTray
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private bool hidden = false;
        bool quitFlag = false;
        bool serviceFlag = true;
        public Process serviceProcess;
        public ProcessStartInfo serviceInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            utility.Config();
            phone.Text = utility.CONFIG.PhoneNumber;
            InitService();
            StartService();
            this.ShowInTaskbar = false;
            this.Hide();
            hidden = true;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (hidden) // this.WindowState == FormWindowState.Minimized)
            {
                // this.WindowState = FormWindowState.Normal;
                this.Show();
                hidden = false;
            }
            else
            {
                // this.WindowState = FormWindowState.Minimized;
                this.Hide();
                hidden = true;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quitFlag)
            {
                this.Hide();
                hidden = true;
                e.Cancel = true;
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            quitFlag = true;
            if (serviceFlag)
                serviceProcess.Kill();

            this.Close();
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            config configForm = new config(phone);
            configForm.Show();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            int funcNum = int.Parse(func.Text);
            string path = Path.Combine(utility.CONFIG.PATH_LOG, $"log{funcNum}.txt");

            if (!utility.IsFileOpen(path))
            {
                var process = new Process();
                Process.Start("notepad.exe", path);
            }
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            if (serviceFlag)
            {
                StopService();
                serviceFlag = !serviceFlag;
            }
            else
            {
                StartService();
                serviceFlag = !serviceFlag;
            }
        }

        private void StartService()
        {
            serviceBtn.Text = "Stop";
            serviceProcess = Process.Start(serviceInfo);
        }
        private void StopService()
        {
            serviceBtn.Text = "Start";
            serviceProcess.Kill();
        }

        private void InitService()
        {
            serviceInfo = new ProcessStartInfo();
            //start.CreateNoWindow = false;
            //start.UseShellExecute = false;
            serviceInfo.FileName = Path.Combine(Directory.GetCurrentDirectory(), "DicomManager.exe");
            //serviceInfo.FileName = @"D:\devTestSetupNotes.txt";
            serviceInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

    }
}
