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
            using (WebClient Client = new WebClient())
            {
                //Client.DownloadProgressChanged;
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new System.Uri("https://nightly.link/hmxmilohax/rock-band-3-deluxe/workflows/build/main/RB3DX-PS3.zip"), "RB3DX-PS3.zip"
                );
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
                this.BeginInvoke((MethodInvoker)delegate {
                label2.Text = "Download Completed! Extracting...";
                ZipFile.ExtractToDirectory("RB3DX-PS3.zip", "RB3DX-PS3");
                label2.Text = "Extracted! Installing with RPCS3...";
                });
            }
        }
    }
}
