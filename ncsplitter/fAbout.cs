using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;


namespace ncsplitter
{
    public partial class fAbout : Form
    {
        public string version_state = "alpha";

        public string str_developed = "Developed by Edgeline";
        public string str_email = "edgeline@mail.ru";
        public string str_vk = "http://vk.com/edgeline";

        public fAbout()
        {
            InitializeComponent();
        }

        public string GetAppVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string ver = String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);

            if (version_state.Length != 0)
                ver += String.Format(" {0}", version_state);

            return ver;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAbout_Load(object sender, EventArgs e)
        {
            labelDev.Text = str_developed;
            linkEMail.Text = str_email;
            linkVK.Text = str_vk;

            labelVersion.Text = "Version: " + GetAppVersion();
        }

        private void linkEMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLinkInBrowser(String.Format("mailto:{0}", linkEMail.Text));
        }

        private void linkVK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLinkInBrowser(linkVK.Text);
        }

        private void linkIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLinkInBrowser(linkIcons.Text);
        }

        private void OpenLinkInBrowser(string link)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(link);
                Process.Start(sInfo);
            }
            catch
            {
                return;
            }
        }
    }
}
