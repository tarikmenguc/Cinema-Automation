namespace SinemaOto
{
    partial class frmoyuncukayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmoyuncukayit));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            kayitbtn = new Button();
            label3 = new Label();
            adtext = new TextBox();
            label4 = new Label();
            soyadtext = new TextBox();
            label5 = new Label();
            ngun = new NumericUpDown();
            nay = new NumericUpDown();
            nyil = new NumericUpDown();
            rberkek = new RadioButton();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            rbkadın = new RadioButton();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            txtbiyo = new TextBox();
            label8 = new Label();
            lblkarakter = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            yönetmenresim = new PictureBox();
            resimyukle = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yönetmenresim).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 45);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(248, 8);
            label2.Name = "label2";
            label2.Size = new Size(219, 31);
            label2.TabIndex = 5;
            label2.Text = "Oyuncu kayıt Ekranı";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(556, 0);
            button1.Name = "button1";
            button1.Size = new Size(43, 45);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 31);
            label1.TabIndex = 0;
            label1.Text = "NetflixandChill.com";
            // 
            // kayitbtn
            // 
            kayitbtn.BackColor = Color.Indigo;
            kayitbtn.Cursor = Cursors.Hand;
            kayitbtn.Dock = DockStyle.Bottom;
            kayitbtn.ForeColor = Color.GhostWhite;
            kayitbtn.Location = new Point(0, 751);
            kayitbtn.Name = "kayitbtn";
            kayitbtn.Size = new Size(599, 45);
            kayitbtn.TabIndex = 20;
            kayitbtn.Text = "Kayıt Tamamla";
            kayitbtn.UseVisualStyleBackColor = false;
            kayitbtn.Click += kayitbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(46, 31);
            label3.TabIndex = 0;
            label3.Text = "AD";
            // 
            // adtext
            // 
            adtext.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adtext.Location = new Point(24, 48);
            adtext.Name = "adtext";
            adtext.Size = new Size(201, 25);
            adtext.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(87, 31);
            label4.TabIndex = 8;
            label4.Text = "SOYAD";
            // 
            // soyadtext
            // 
            soyadtext.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            soyadtext.Location = new Point(19, 109);
            soyadtext.Name = "soyadtext";
            soyadtext.Size = new Size(201, 25);
            soyadtext.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 134);
            label5.Name = "label5";
            label5.Size = new Size(155, 31);
            label5.TabIndex = 10;
            label5.Text = "Doğum Tarihi";
            // 
            // ngun
            // 
            ngun.ForeColor = Color.Indigo;
            ngun.Location = new Point(24, 165);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.Size = new Size(54, 38);
            ngun.TabIndex = 7;
            ngun.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // nay
            // 
            nay.ForeColor = Color.Indigo;
            nay.Location = new Point(86, 165);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.Size = new Size(54, 38);
            nay.TabIndex = 11;
            nay.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nyil
            // 
            nyil.ForeColor = Color.Indigo;
            nyil.Location = new Point(146, 165);
            nyil.Maximum = new decimal(new int[] { 2010, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.Size = new Size(79, 38);
            nyil.TabIndex = 12;
            nyil.Value = new decimal(new int[] { 2003, 0, 0, 0 });
            // 
            // rberkek
            // 
            rberkek.AutoSize = true;
            rberkek.Checked = true;
            rberkek.FlatStyle = FlatStyle.Flat;
            rberkek.Location = new Point(19, 243);
            rberkek.Name = "rberkek";
            rberkek.Size = new Size(91, 35);
            rberkek.TabIndex = 7;
            rberkek.TabStop = true;
            rberkek.Text = "Erkek";
            rberkek.UseVisualStyleBackColor = true;
            rberkek.CheckedChanged += rberkek_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 212);
            label6.Name = "label6";
            label6.Size = new Size(95, 31);
            label6.TabIndex = 13;
            label6.Text = "Cinsiyet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 282);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rbkadın
            // 
            rbkadın.AutoSize = true;
            rbkadın.FlatStyle = FlatStyle.Flat;
            rbkadın.Location = new Point(141, 243);
            rbkadın.Name = "rbkadın";
            rbkadın.Size = new Size(93, 35);
            rbkadın.TabIndex = 15;
            rbkadın.Text = "Kadın";
            rbkadın.UseVisualStyleBackColor = true;
            rbkadın.CheckedChanged += rbkadın_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(141, 282);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(rbkadın);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(rberkek);
            groupBox2.Controls.Add(nyil);
            groupBox2.Controls.Add(nay);
            groupBox2.Controls.Add(ngun);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(soyadtext);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(adtext);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(12, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 359);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 31);
            label11.TabIndex = 0;
            label11.Text = "Biyografi";
            // 
            // txtbiyo
            // 
            txtbiyo.Dock = DockStyle.Fill;
            txtbiyo.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtbiyo.Location = new Point(3, 34);
            txtbiyo.MaxLength = 300;
            txtbiyo.Multiline = true;
            txtbiyo.Name = "txtbiyo";
            txtbiyo.Size = new Size(517, 266);
            txtbiyo.TabIndex = 7;
            txtbiyo.TextChanged += txtbiyo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(101, 11);
            label8.Name = "label8";
            label8.Size = new Size(119, 17);
            label8.TabIndex = 8;
            label8.Text = "(Max 300 karakter)";
            // 
            // lblkarakter
            // 
            lblkarakter.AutoSize = true;
            lblkarakter.Location = new Point(472, 263);
            lblkarakter.Name = "lblkarakter";
            lblkarakter.Size = new Size(53, 31);
            lblkarakter.TabIndex = 17;
            lblkarakter.Text = "300";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblkarakter);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtbiyo);
            groupBox3.Controls.Add(label11);
            groupBox3.ForeColor = Color.Indigo;
            groupBox3.Location = new Point(6, 442);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(523, 303);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 17);
            label7.Name = "label7";
            label7.Size = new Size(75, 31);
            label7.TabIndex = 8;
            label7.Text = "Resim";
            // 
            // yönetmenresim
            // 
            yönetmenresim.Image = (Image)resources.GetObject("yönetmenresim.Image");
            yönetmenresim.Location = new Point(6, 59);
            yönetmenresim.Name = "yönetmenresim";
            yönetmenresim.Size = new Size(198, 181);
            yönetmenresim.SizeMode = PictureBoxSizeMode.Zoom;
            yönetmenresim.TabIndex = 10;
            yönetmenresim.TabStop = false;
            yönetmenresim.Click += yönetmenresim_Click;
            // 
            // resimyukle
            // 
            resimyukle.BackColor = Color.Indigo;
            resimyukle.Cursor = Cursors.Hand;
            resimyukle.Dock = DockStyle.Bottom;
            resimyukle.ForeColor = Color.GhostWhite;
            resimyukle.Location = new Point(3, 245);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(214, 45);
            resimyukle.TabIndex = 15;
            resimyukle.Text = "Resim Yükle";
            resimyukle.UseVisualStyleBackColor = false;
            resimyukle.Click += resimyukle_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(resimyukle);
            groupBox1.Controls.Add(yönetmenresim);
            groupBox1.Controls.Add(label7);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(312, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 293);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // frmoyuncukayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(599, 796);
            Controls.Add(panel1);
            Controls.Add(kayitbtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "frmoyuncukayit";
            StartPosition = FormStartPosition.Manual;
            Text = "frmoyuncukayit";
            Load += frmoyuncukayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yönetmenresim).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button kayitbtn;
        private Label label3;
        private TextBox adtext;
        private Label label4;
        private TextBox soyadtext;
        private Label label5;
        private NumericUpDown ngun;
        private NumericUpDown nay;
        private NumericUpDown nyil;
        private RadioButton rberkek;
        private Label label6;
        private PictureBox pictureBox1;
        private RadioButton rbkadın;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private Label label11;
        private TextBox txtbiyo;
        private Label label8;
        private Label lblkarakter;
        private GroupBox groupBox3;
        private Label label7;
        private PictureBox yönetmenresim;
        private Button resimyukle;
        private GroupBox groupBox1;
    }
}