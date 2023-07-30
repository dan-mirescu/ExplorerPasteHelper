using System.Diagnostics;

namespace ExplorerPasteHelper
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.flaticon.com/free-icons/paste",
                UseShellExecute = true
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/dan-mirescu/ExplorerPasteHelper",
                UseShellExecute = true
            });
        }
    }
}
