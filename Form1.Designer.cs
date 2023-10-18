namespace RB3DX_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NoLongerAHomie = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            comboBox1 = new ComboBox();
            UpdateButton = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            play = new Button();
            dxLogo = new PictureBox();
            tabPage2 = new TabPage();
            BrowseDevHDD0 = new Button();
            label3 = new Label();
            devhdd0 = new TextBox();
            BrowseRPCS3 = new Button();
            label2 = new Label();
            RPCS3Path = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            NoLongerAHomie.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxLogo).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // NoLongerAHomie
            // 
            NoLongerAHomie.Controls.Add(tabPage1);
            NoLongerAHomie.Controls.Add(tabPage2);
            NoLongerAHomie.Location = new Point(-1, 0);
            NoLongerAHomie.Margin = new Padding(4, 5, 4, 5);
            NoLongerAHomie.Name = "NoLongerAHomie";
            NoLongerAHomie.SelectedIndex = 0;
            NoLongerAHomie.Size = new Size(1146, 752);
            NoLongerAHomie.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(1, 13, 25);
            tabPage1.BackgroundImage = Properties.Resources.headerbg;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(UpdateButton);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(play);
            tabPage1.Controls.Add(dxLogo);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1138, 714);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(863, 430);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 8;
            label1.Text = "Update from:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "main", "dev" });
            comboBox1.Location = new Point(863, 458);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "main";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(863, 523);
            UpdateButton.Margin = new Padding(4, 5, 4, 5);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(156, 38);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Update RB3DX";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.milohax;
            pictureBox1.Location = new Point(13, 10);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { resources.GetString("listBox1.Items"), "", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2"), "", resources.GetString("listBox1.Items3"), "", resources.GetString("listBox1.Items4") });
            listBox1.Location = new Point(13, 253);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(840, 404);
            listBox1.TabIndex = 2;
            // 
            // play
            // 
            play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            play.Location = new Point(863, 572);
            play.Margin = new Padding(4, 5, 4, 5);
            play.Name = "play";
            play.Size = new Size(259, 88);
            play.TabIndex = 1;
            play.Text = "Play!";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // dxLogo
            // 
            dxLogo.BackColor = Color.Transparent;
            dxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            dxLogo.ErrorImage = null;
            dxLogo.Image = Properties.Resources.logo;
            dxLogo.ImageLocation = "";
            dxLogo.InitialImage = null;
            dxLogo.Location = new Point(13, 10);
            dxLogo.Margin = new Padding(4, 5, 4, 5);
            dxLogo.Name = "dxLogo";
            dxLogo.Size = new Size(536, 158);
            dxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            dxLogo.TabIndex = 0;
            dxLogo.TabStop = false;
            dxLogo.UseWaitCursor = true;
            dxLogo.Click += dxLogo_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(1, 13, 25);
            tabPage2.BackgroundImage = Properties.Resources.headerbg;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(BrowseDevHDD0);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(devhdd0);
            tabPage2.Controls.Add(BrowseRPCS3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(RPCS3Path);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1138, 714);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // BrowseDevHDD0
            // 
            BrowseDevHDD0.Location = new Point(436, 205);
            BrowseDevHDD0.Margin = new Padding(4, 5, 4, 5);
            BrowseDevHDD0.Name = "BrowseDevHDD0";
            BrowseDevHDD0.Size = new Size(107, 38);
            BrowseDevHDD0.TabIndex = 5;
            BrowseDevHDD0.Text = "Browse";
            BrowseDevHDD0.UseVisualStyleBackColor = true;
            BrowseDevHDD0.Click += BrowseDevHDD0_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(33, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "dev_hdd0";
            // 
            // devhdd0
            // 
            devhdd0.Location = new Point(33, 205);
            devhdd0.Margin = new Padding(4, 5, 4, 5);
            devhdd0.Name = "devhdd0";
            devhdd0.ReadOnly = true;
            devhdd0.Size = new Size(393, 31);
            devhdd0.TabIndex = 3;
            // 
            // BrowseRPCS3
            // 
            BrowseRPCS3.Location = new Point(436, 93);
            BrowseRPCS3.Margin = new Padding(4, 5, 4, 5);
            BrowseRPCS3.Name = "BrowseRPCS3";
            BrowseRPCS3.Size = new Size(107, 38);
            BrowseRPCS3.TabIndex = 2;
            BrowseRPCS3.Text = "Browse";
            BrowseRPCS3.UseVisualStyleBackColor = true;
            BrowseRPCS3.Click += BrowseRPCS3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(33, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "RPCS3.exe";
            // 
            // RPCS3Path
            // 
            RPCS3Path.Location = new Point(33, 93);
            RPCS3Path.Margin = new Padding(4, 5, 4, 5);
            RPCS3Path.Name = "RPCS3Path";
            RPCS3Path.ReadOnly = true;
            RPCS3Path.Size = new Size(393, 31);
            RPCS3Path.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(33, 298);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1143, 750);
            Controls.Add(NoLongerAHomie);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Rock Band 3 Deluxe Launcher";
            NoLongerAHomie.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxLogo).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl NoLongerAHomie;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox dxLogo;
        private Button play;
        private ListBox listBox1;
        private TextBox RPCS3Path;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Button BrowseRPCS3;
        private OpenFileDialog openFileDialog1;
        private Button BrowseDevHDD0;
        private Label label3;
        private TextBox devhdd0;
        private PictureBox pictureBox1;
        private Button UpdateButton;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}