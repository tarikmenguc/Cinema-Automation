namespace SinemaOto
{
    partial class FrmSalonAtama
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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            btntemizle = new Button();
            btnolustur = new Button();
            groupBox7 = new GroupBox();
            lblkoltuksayisi = new Label();
            cbsalon = new ComboBox();
            groupBox6 = new GroupBox();
            flpanel = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            nyil = new NumericUpDown();
            nay = new NumericUpDown();
            ngun = new NumericUpDown();
            lblgun = new Label();
            groupBox4 = new GroupBox();
            cbfilmadi = new ComboBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cbdoolusaatler = new ComboBox();
            lblsecilen = new Label();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            groupBox4.SuspendLayout();
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
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 63);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(218, 16);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 31);
            label2.TabIndex = 4;
            label2.Text = "Salon Atama Ekranı";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(481, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(66, 63);
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
            label1.Location = new Point(0, 16);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 31);
            label1.TabIndex = 0;
            label1.Text = "NetflixandChill.com";
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.Indigo;
            btntemizle.Cursor = Cursors.Hand;
            btntemizle.ForeColor = Color.GhostWhite;
            btntemizle.Location = new Point(160, 290);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(141, 38);
            btntemizle.TabIndex = 52;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // btnolustur
            // 
            btnolustur.BackColor = Color.Indigo;
            btnolustur.Cursor = Cursors.Hand;
            btnolustur.ForeColor = Color.GhostWhite;
            btnolustur.Location = new Point(9, 290);
            btnolustur.Name = "btnolustur";
            btnolustur.Size = new Size(149, 38);
            btnolustur.TabIndex = 51;
            btnolustur.Text = "Tamamla";
            btnolustur.UseVisualStyleBackColor = false;
            btnolustur.Click += btnolustur_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblkoltuksayisi);
            groupBox7.Controls.Add(cbsalon);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.Indigo;
            groupBox7.Location = new Point(9, 143);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(307, 66);
            groupBox7.TabIndex = 50;
            groupBox7.TabStop = false;
            groupBox7.Text = "Salon Adı";
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblkoltuksayisi.ForeColor = Color.Gold;
            lblkoltuksayisi.Location = new Point(203, 0);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(105, 20);
            lblkoltuksayisi.TabIndex = 36;
            lblkoltuksayisi.Text = "lblkoltuksayisi";
            // 
            // cbsalon
            // 
            cbsalon.Dock = DockStyle.Bottom;
            cbsalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsalon.FlatStyle = FlatStyle.Flat;
            cbsalon.FormattingEnabled = true;
            cbsalon.Location = new Point(10, 27);
            cbsalon.Name = "cbsalon";
            cbsalon.Size = new Size(294, 36);
            cbsalon.TabIndex = 30;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(flpanel);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.Indigo;
            groupBox6.Location = new Point(332, 71);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(162, 322);
            groupBox6.TabIndex = 49;
            groupBox6.TabStop = false;
            groupBox6.Text = "Saat/Seans";
            // 
            // flpanel
            // 
            flpanel.AutoScroll = true;
            flpanel.Dock = DockStyle.Fill;
            flpanel.FlowDirection = FlowDirection.TopDown;
            flpanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            flpanel.Location = new Point(10, 30);
            flpanel.Name = "flpanel";
            flpanel.Size = new Size(149, 289);
            flpanel.TabIndex = 54;
            flpanel.WrapContents = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nyil);
            groupBox5.Controls.Add(nay);
            groupBox5.Controls.Add(ngun);
            groupBox5.Controls.Add(lblgun);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.Indigo;
            groupBox5.Location = new Point(9, 215);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(307, 69);
            groupBox5.TabIndex = 48;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tarih";
            // 
            // nyil
            // 
            nyil.BorderStyle = BorderStyle.None;
            nyil.ForeColor = Color.Indigo;
            nyil.Location = new Point(187, 29);
            nyil.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.Size = new Size(79, 30);
            nyil.TabIndex = 33;
            nyil.TextAlign = HorizontalAlignment.Center;
            nyil.Value = new decimal(new int[] { 2003, 0, 0, 0 });
            // 
            // nay
            // 
            nay.BorderStyle = BorderStyle.None;
            nay.ForeColor = Color.Indigo;
            nay.Location = new Point(108, 29);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.Size = new Size(54, 30);
            nay.TabIndex = 32;
            nay.TextAlign = HorizontalAlignment.Center;
            nay.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ngun
            // 
            ngun.BorderStyle = BorderStyle.None;
            ngun.ForeColor = Color.Indigo;
            ngun.Location = new Point(23, 29);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.Size = new Size(54, 30);
            ngun.TabIndex = 31;
            ngun.TextAlign = HorizontalAlignment.Center;
            ngun.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // lblgun
            // 
            lblgun.AutoSize = true;
            lblgun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblgun.ForeColor = Color.Gold;
            lblgun.Location = new Point(205, 0);
            lblgun.Name = "lblgun";
            lblgun.Size = new Size(87, 20);
            lblgun.TabIndex = 30;
            lblgun.Text = "gg/aa/yyyy";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbfilmadi);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.Indigo;
            groupBox4.Location = new Point(9, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(307, 66);
            groupBox4.TabIndex = 47;
            groupBox4.TabStop = false;
            groupBox4.Text = "Film Adı";
            // 
            // cbfilmadi
            // 
            cbfilmadi.Dock = DockStyle.Bottom;
            cbfilmadi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfilmadi.FlatStyle = FlatStyle.Flat;
            cbfilmadi.FormattingEnabled = true;
            cbfilmadi.Location = new Point(10, 27);
            cbfilmadi.Name = "cbfilmadi";
            cbfilmadi.Size = new Size(294, 36);
            cbfilmadi.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbdoolusaatler);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(0, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(313, 62);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dolu Saatler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(210, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 36;
            label3.Text = "label3";
            // 
            // cbdoolusaatler
            // 
            cbdoolusaatler.Dock = DockStyle.Bottom;
            cbdoolusaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdoolusaatler.FlatStyle = FlatStyle.Flat;
            cbdoolusaatler.FormattingEnabled = true;
            cbdoolusaatler.Location = new Point(10, 23);
            cbdoolusaatler.Name = "cbdoolusaatler";
            cbdoolusaatler.Size = new Size(300, 36);
            cbdoolusaatler.TabIndex = 30;
            // 
            // lblsecilen
            // 
            lblsecilen.AutoSize = true;
            lblsecilen.Location = new Point(358, 407);
            lblsecilen.Name = "lblsecilen";
            lblsecilen.Size = new Size(79, 31);
            lblsecilen.TabIndex = 54;
            lblsecilen.Text = "label4";
            // 
            // FrmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(547, 447);
            Controls.Add(lblsecilen);
            Controls.Add(groupBox1);
            Controls.Add(btntemizle);
            Controls.Add(btnolustur);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmSalonAtama";
            Text = "FrmSalonAtama";
            Load += FrmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button btntemizle;
        private Button btnolustur;
        private GroupBox groupBox7;
        private Label lblkoltuksayisi;
        private ComboBox cbsalon;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label lblgun;
        private GroupBox groupBox4;
        private ComboBox cbfilmadi;
        private NumericUpDown nyil;
        private NumericUpDown nay;
        private NumericUpDown ngun;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox cbdoolusaatler;
        private FlowLayoutPanel flpanel;
        private Label lblsecilen;
    }
}