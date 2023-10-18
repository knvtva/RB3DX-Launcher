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
            listBox1 = new ListBox();
            play = new Button();
            dxLogo = new PictureBox();
            tabPage2 = new TabPage();
            NoLongerAHomie.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dxLogo).BeginInit();
            SuspendLayout();
            // 
            // NoLongerAHomie
            // 
            NoLongerAHomie.Controls.Add(tabPage1);
            NoLongerAHomie.Controls.Add(tabPage2);
            NoLongerAHomie.Location = new Point(-1, 0);
            NoLongerAHomie.Name = "NoLongerAHomie";
            NoLongerAHomie.SelectedIndex = 0;
            NoLongerAHomie.Size = new Size(802, 451);
            NoLongerAHomie.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(1, 13, 25);
            tabPage1.BackgroundImage = Properties.Resources.headerbg;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(play);
            tabPage1.Controls.Add(dxLogo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(604, 296);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose Branch";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(604, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "main";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { resources.GetString("listBox1.Items"), "", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2"), "", resources.GetString("listBox1.Items3"), "", resources.GetString("listBox1.Items4") });
            listBox1.Location = new Point(9, 152);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(589, 244);
            listBox1.TabIndex = 2;
            // 
            // play
            // 
            play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            play.Location = new Point(604, 343);
            play.Name = "play";
            play.Size = new Size(181, 53);
            play.TabIndex = 1;
            play.Text = "Play!";
            play.UseVisualStyleBackColor = true;
            // 
            // dxLogo
            // 
            dxLogo.BackColor = Color.Transparent;
            dxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            dxLogo.ErrorImage = null;
            dxLogo.Image = Properties.Resources.logo;
            dxLogo.ImageLocation = "";
            dxLogo.InitialImage = null;
            dxLogo.Location = new Point(9, 6);
            dxLogo.Name = "dxLogo";
            dxLogo.Size = new Size(375, 95);
            dxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            dxLogo.TabIndex = 0;
            dxLogo.TabStop = false;
            dxLogo.UseWaitCursor = true;
            dxLogo.Click += dxLogo_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.BackgroundImage = Properties.Resources.headerbg;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(NoLongerAHomie);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Rock Band 3 Deluxe Launcher";
            NoLongerAHomie.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl NoLongerAHomie;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox dxLogo;
        private Button play;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label1;
    }
}