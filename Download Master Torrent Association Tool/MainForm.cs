using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

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

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = textBoxPassword.Text;
            Properties.Settings.Default.IPAddress = textBoxIP.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;

            Properties.Settings.Default.Save();

            if (checkBoxCurrent.Checked)
            {
                RegistryKey currentKey = Registry.CurrentUser;

                currentKey = currentKey.OpenSubKey("Software");

                currentKey = currentKey.OpenSubKey("Classes", true);

                currentKey = currentKey.CreateSubKey("magnet");

                currentKey.SetValue("", "URL:Magnet Protocol");
                currentKey.SetValue("Content Type", "application/x-magnet");

                currentKey.CreateSubKey("DefaultIcon");
                //Can link icon here is we have one.

                currentKey = currentKey.CreateSubKey("shell");
                currentKey = currentKey.CreateSubKey("open");
                currentKey.SetValue("FriendlyAppName", "Download Master");

                currentKey = currentKey.CreateSubKey("command");
                currentKey.SetValue("", "\"" + Application.ExecutablePath + "\" \"%1\"");
            }

            if (checkBoxAll.Checked)
            {
                RegistryKey rootKey = Registry.ClassesRoot;
                rootKey = rootKey.CreateSubKey("magnet");

                rootKey.SetValue("", "URL:Magnet Protocol");
                rootKey.SetValue("Content Type", "application/x-magnet");

                rootKey.CreateSubKey("DefaultIcon");
                //Can link icon here is we have one.

                rootKey = rootKey.CreateSubKey("shell");
                rootKey = rootKey.CreateSubKey("open");
                rootKey.SetValue("FriendlyAppName", "Download Master");

                rootKey = rootKey.CreateSubKey("command");
                rootKey.SetValue("", "\"" + Application.ExecutablePath + "\" \"%1\"");
            }

            
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
