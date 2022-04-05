using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DicomServerTray
{
    public partial class config : Form
    {

        public config()
        {
            InitializeComponent();
        }

        public ToolStripStatusLabel tssLabel = new ToolStripStatusLabel();
        public config(ToolStripStatusLabel p_label)
        {
            InitializeComponent();
            tssLabel = p_label;
        }

        private void jpgPathBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = jpgPath.Text;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                jpgPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void dcmPathBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = dcmPath.Text;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                dcmPath.Text = folderBrowserDialog.SelectedPath;
            }
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            utility.CONFIG.PATH_JPG = jpgPath.Text;
            utility.CONFIG.PATH_JPG_Processed = Path.Combine(jpgPath.Text, "Processed");
            utility.CONFIG.PATH_DCM = dcmPath.Text;
            utility.CONFIG.PATH_DCM_Processed = Path.Combine(dcmPath.Text, "Processed");
            utility.CONFIG.DB_IP = IPADRESS.Text ;
            utility.CONFIG.USER_ID = USERID.Text;
            utility.CONFIG.DB_NAME = DBNAME.Text;
            utility.CONFIG.DB_PWD = DBPWD.Text;
            utility.CONFIG.QRServerHost = QRHOST.Text;
            utility.CONFIG.QRServerPort = int.Parse(QRPORT.Text);
            utility.CONFIG.QRServerAET = SERVERAET.Text;
            utility.CONFIG.AET = AET.Text;

            utility.CONFIG.TestServerHost = TESTHOST.Text;
            utility.CONFIG.TestServerPort = int.Parse(TESTPORT.Text);
            utility.CONFIG.TestServerAET = TESTSERVERAET.Text;
            utility.CONFIG.TestAET = TESTAET.Text;

            utility.CONFIG.PhoneNumber = PHONE.Text;

            utility.WriteConfig();

            tssLabel.Text = PHONE.Text;

            this.Close();
        }

        private void config_Load(object sender, EventArgs e)
        {
            jpgPath.Text = utility.CONFIG.PATH_JPG;
            dcmPath.Text = utility.CONFIG.PATH_DCM;
            IPADRESS.Text = utility.CONFIG.DB_IP;
            USERID.Text = utility.CONFIG.USER_ID;
            DBNAME.Text = utility.CONFIG.DB_NAME;
            DBPWD.Text = utility.CONFIG.DB_PWD;
            QRHOST.Text = utility.CONFIG.QRServerHost;
            QRPORT.Text = utility.CONFIG.QRServerPort.ToString();
            SERVERAET.Text = utility.CONFIG.QRServerAET;
            AET.Text = utility.CONFIG.AET;

            TESTHOST.Text = utility.CONFIG.TestServerHost;
            TESTPORT.Text = utility.CONFIG.TestServerPort.ToString();
            TESTSERVERAET.Text = utility.CONFIG.TestServerAET;
            TESTAET.Text = utility.CONFIG.TestAET;

            PHONE.Text = utility.CONFIG.PhoneNumber;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
