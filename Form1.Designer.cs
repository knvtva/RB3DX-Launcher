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
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(play);
            tabPage1.Controls.Add(dxLogo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
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
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}