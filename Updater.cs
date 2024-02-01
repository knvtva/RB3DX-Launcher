using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection.Emit;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace RB3DX_Launcher
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
            if (System.IO.File.Exists("RB3DX-PS3.zip"))
            {
                System.IO.File.Delete("RB3DX-PS3.zip");
            }
            if (System.IO.Directory.Exists("RB3DX-PS3"))
            {
                System.IO.Directory.Delete("RB3DX-PS3", true);
            }


            if (System.IO.File.Exists("RB3DX.config"))
            {
                string configPath = "RB3DX.config";
                string[] configLines = System.IO.File.ReadAllLines(configPath);
                string branch = "main";
                if (configLines.Length > 2)
                {
                    branch = configLines[2];
                }
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    try
                    {
                       // debug MessageBox.Show("https://nightly.link/hmxmilohax/rock-band-3-deluxe/workflows/build/" + branch + "/RB3DX-PS3.zip");
                        Client.DownloadFileAsync(new System.Uri("https://nightly.link/hmxmilohax/rock-band-3-deluxe/workflows/build/" + branch + "/RB3DX-PS3.zip"), "RB3DX-PS3.zip");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        Logger.LogError(ex.Message);
                        // Handle the exception as needed.
                    }
                }

            }

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {

                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                //double percentage = bytesIn / totalBytes * 100;
                label2.Text = "Downloaded " + e.BytesReceived / 1000 / 1000 + "MB";
                // progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (e.Error != null)
                {
                    MessageBox.Show("Download Error: " + e.Error.Message);
                    // Handle the download error here.
                }
                label2.Text = "Download Completed! Extracting...";
                ZipFile.ExtractToDirectory("RB3DX-PS3.zip", "RB3DX-PS3");
                // read all files ending in .pkg and install them with rpcs3
                //string pkgDirectory = Path.GetFullPath("RB3DX-PS3");
                string[] pkgFiles = Directory.GetFiles("RB3DX-PS3", "*.pkg");
                
                label2.Text = "Extracted! Installing with RPCS3...";
                // read config file and populate rpcs3path
                string configPath = "RB3DX.config";
                string[] configLines = System.IO.File.ReadAllLines(configPath);
                string rpcs3path = configLines[0];
                foreach (string pkgFile in pkgFiles)
                {
                    string pkgFilePath = Path.GetFullPath(pkgFile); // Combine directory path and file name
                    Process.Start(new ProcessStartInfo(rpcs3path)
                    {
                        Arguments = "--installpkg " + pkgFilePath, // Enclose the file path in double quotes
                        UseShellExecute = true
                    });
                    Logger.LogDebug("--installpkg " + pkgFilePath);
                }
                Task.Delay(1000);
                label2.Text = "Passed to RPCS3🎊";
                Task.Delay(1000);
                this.Close();
            });
        }
    }
}
