using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace Download_Master_Torrent_Association_Tool
{
    public partial class MainForm : Form
    {

        public MainForm()
        {            
            InitializeComponent();

            textBoxUsername.Text = Properties.Settings.Default.Username;
            textBoxPassword.Text = Properties.Settings.Default.Password;
            textBoxIP.Text = Properties.Settings.Default.IPAddress;
            textBoxPort.Text = Properties.Settings.Default.Port;

            checkBoxEd2k.Checked = Properties.Settings.Default.ed2k;
            checkBoxMagnet.Checked = Properties.Settings.Default.Magnet;
            checkBoxNZB.Checked = Properties.Settings.Default.NZB;
            checkBoxTorrent.Checked = Properties.Settings.Default.Torrent;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = textBoxPassword.Text;
            Properties.Settings.Default.IPAddress = textBoxIP.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;

            Properties.Settings.Default.ed2k = checkBoxEd2k.Checked;
            Properties.Settings.Default.Magnet = checkBoxMagnet.Checked;
            Properties.Settings.Default.NZB = checkBoxNZB.Checked;
            Properties.Settings.Default.Torrent = checkBoxTorrent.Checked;

            Properties.Settings.Default.Save();

            
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8))
            {
                //Either digit or backspace.
            }
            else
            {
                //Block KeyChar
                e.Handled = true;
            }
        }

        private void textBoxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == '.'))
            {
                //Either digit, backspace or '.'.
            }
            else
            {
                //Block KeyChar
                e.Handled = true;
            }
        }

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start("https://github.com/CoenraadS/Unofficial-ASUSWRT-Download-Master-Torrent-Association-Tool/releases");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
