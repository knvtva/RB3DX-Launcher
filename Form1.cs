using System.Diagnostics;
using System.Windows.Forms.Design;

namespace RB3DX_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dxLogo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://rb3dx.neocities.org/") { UseShellExecute = true });
        }

        private void BrowseRPCS3_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {

                    if (fbd.FileName.Contains("rpcs3.exe"))
                    {
                        RPCS3Path.Text = fbd.FileName;
                        string path = fbd.FileName;
                        try { devhdd0.Text = Path.GetDirectoryName(fbd.FileName) + @"\dev_hdd0"; }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show(Text = "This is not a valid RPCS3 instance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void BrowseDevHDD0_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Directory.GetFiles(fbd.SelectedPath).Length == 0)
                    {
                        devhdd0.Text = fbd.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show(Text = "This is not a valid folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            string rpcs3ExecutablePath = RPCS3Path.Text;
            string gamePath = devhdd0.Text + "/game/BLUS30463/USRDIR/EBOOT.bin";

            Process.Start(new ProcessStartInfo(rpcs3ExecutablePath)
            {
                Arguments = "--no-gui " + "\"" + gamePath + "\"",
                UseShellExecute = true
            });
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // show updater form
            Updater updater = new Updater();
            updater.ShowDialog();

        }
    }
}