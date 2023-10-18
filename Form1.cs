using System.Diagnostics;

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
    }
}