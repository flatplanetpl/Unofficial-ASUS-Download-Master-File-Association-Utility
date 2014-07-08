using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Download_Master_Torrent_Association_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                Application.Run(new MainForm());
            }
            else
            {
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Application;
                notifyIcon.BalloonTipTitle = "ASUS Torrent Associator";
                notifyIcon.Visible = true;

                string username = Properties.Settings.Default.Username;
                string password = Properties.Settings.Default.Password;
                string ipAddress = Properties.Settings.Default.IPAddress;
                string port = Properties.Settings.Default.Port;
                string url = "";
                string response = "";
                string link = args[0];

                url = "http://" + ipAddress + ':' + port;
                url += "/downloadmaster/dm_apply.cgi?action_mode=DM_ADD&download_type=5&again=no&usb_dm_url=";
                url += link;

                using (WebClient client = new WebClient())
                {
                    string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
                    client.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

                    try
                    {
                        response = client.DownloadString(url);

                        if (response == "ACK_SUCCESS" || response == "ACK_SUCESS")
                        {
                            notifyIcon.BalloonTipIcon = ToolTipIcon.None;
                            response = "Torrent added successfully";
                        }
                        else
                        {
                            notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
                            response = "File rejected by router";
                        }
                    }
                    catch (ArgumentException exc)
                    {
                        response = exc.Message;
                        notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    }
                    catch (WebException ex)
                    {
                        response = ex.Message;
                        notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    }

                }

                notifyIcon.BalloonTipText = response;
                notifyIcon.ShowBalloonTip(2000);

            }
        }
    }
}
