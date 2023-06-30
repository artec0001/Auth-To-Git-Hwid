using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawGit_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            string URL = "https://raw.githubusercontent.com/artec0001/resource-auth/main/hwids";
            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            if (client.DownloadString(URL).Contains(HWID))
            {
                MessageBox.Show("Você esta Libeirado");
                label1.Visible = false;
            }
            else
            {

            }
        }
    }
}
