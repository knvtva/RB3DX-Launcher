using System.Diagnostics;
using System.Windows.Forms.Design;

namespace RB3DX_Launcher
{
    public partial class Form1 : Form
    {

        public static bool isGameStarted = false;

        public Form1()
        {
            InitializeComponent();
            // read config file and populate rpcs3path and devhdd0 path
            string configPath = "RB3DX.config";
            if (System.IO.File.Exists(configPath))
            {
                string[] configLines = System.IO.File.ReadAllLines(configPath);
                RPCS3Path.Text = configLines[0];
                devhdd0.Text = configLines[1];
                comboBox1.Text = configLines[2];
            }
            Logger.LogDebug(isGameStarted);
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

            try
            {
                Process.Start(new ProcessStartInfo(rpcs3ExecutablePath)
                {
                    Arguments = "--no-gui " + "\"" + gamePath + "\"",
                    UseShellExecute = true
                });
                Logger.LogInfo("Found the EBOOT.bin, Booting the game!");
                isGameStarted = true;
                Logger.LogDebug(isGameStarted);
            }
            catch
            {
                MessageBox.Show(Text = "Failed to launch. Couldn't find the EBOOT.bin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Couldn't find the EBOOT.bin, Does the game exist in that directory?");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // show updater form
            Updater updater = new Updater();
            updater.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // write a config file for the launcher with dev hdd0 path and rpcs3 path
            string rpcs3ExecutablePath = RPCS3Path.Text;
            string hddPath = devhdd0.Text;
            string configPath = "RB3DX.config";
            string branch = comboBox1.Text;
            string[] configLines = { rpcs3ExecutablePath, hddPath, branch };
            File.WriteAllLines(configPath, configLines);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rpcs3ExecutablePath = RPCS3Path.Text;
            string hddPath = devhdd0.Text;
            string configPath = "RB3DX.config";
            string branch = comboBox1.Text;
            string[] configLines = { rpcs3ExecutablePath, hddPath, branch };
            File.WriteAllLines(configPath, configLines);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acePath = devhdd0.Text + "/game/BLUS30463/USRDIR/ace.dta";
            System.Diagnostics.Process.Start("notepad.exe", acePath);
        }
    }
}