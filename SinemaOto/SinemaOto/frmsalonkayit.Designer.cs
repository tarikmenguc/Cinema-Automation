namespace SinemaOto
{
    partial class frmsalonkayit
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
            groupBox2 = new GroupBox();
            resimyukle = new Button();
            cbkoltuksayisi = new ComboBox();
            koltuksayisilbl = new Label();
            salonaditxt = new TextBox();
            salonadilbl = new Label();
            groupBox1 = new GroupBox();
            panelsalon = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(248, 8);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.TabIndex = 5;
            label2.Text = "Salon kayıt Ekranı";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(resimyukle);
            groupBox2.Controls.Add(cbkoltuksayisi);
            groupBox2.Controls.Add(koltuksayisilbl);
            groupBox2.Controls.Add(salonaditxt);
            groupBox2.Controls.Add(salonadilbl);
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(34, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 182);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // resimyukle
            // 
            resimyukle.BackColor = Color.Indigo;
            resimyukle.Cursor = Cursors.Hand;
            resimyukle.ForeColor = Color.GhostWhite;
            resimyukle.Location = new Point(6, 118);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(214, 45);
            resimyukle.TabIndex = 16;
            resimyukle.Text = "Kaydet";
            resimyukle.UseVisualStyleBackColor = false;
            resimyukle.Click += resimyukle_Click;
            // 
            // cbkoltuksayisi
            // 
            cbkoltuksayisi.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cbkoltuksayisi.ForeColor = Color.Indigo;
            cbkoltuksayisi.FormattingEnabled = true;
            cbkoltuksayisi.Location = new Point(230, 56);
            cbkoltuksayisi.Name = "cbkoltuksayisi";
            cbkoltuksayisi.Size = new Size(201, 25);
            cbkoltuksayisi.TabIndex = 9;
            cbkoltuksayisi.SelectedIndexChanged += cbkoltuksayisi_SelectedIndexChanged;
            // 
            // koltuksayisilbl
            // 
            koltuksayisilbl.AutoSize = true;
            koltuksayisilbl.Location = new Point(230, 22);
            koltuksayisilbl.Name = "koltuksayisilbl";
            koltuksayisilbl.Size = new Size(148, 31);
            koltuksayisilbl.TabIndex = 8;
            koltuksayisilbl.Text = "Koltuk Sayısı";
            // 
            // salonaditxt
            // 
            salonaditxt.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            salonaditxt.ForeColor = Color.Indigo;
            salonaditxt.Location = new Point(6, 56);
            salonaditxt.Name = "salonaditxt";
            salonaditxt.Size = new Size(201, 25);
            salonaditxt.TabIndex = 7;
            // 
            // salonadilbl
            // 
            salonadilbl.AutoSize = true;
            salonadilbl.Location = new Point(6, 22);
            salonadilbl.Name = "salonadilbl";
            salonadilbl.Size = new Size(113, 31);
            salonadilbl.TabIndex = 0;
            salonadilbl.Text = "Salon Adı";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panelsalon);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(12, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 475);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panelsalon
            // 
            panelsalon.AutoScroll = true;
            panelsalon.BackColor = Color.WhiteSmoke;
            panelsalon.Dock = DockStyle.Fill;
            panelsalon.Location = new Point(3, 34);
            panelsalon.Name = "panelsalon";
            panelsalon.Size = new Size(569, 438);
            panelsalon.TabIndex = 0;
            // 
            // frmsalonkayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(599, 796);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "frmsalonkayit";
            StartPosition = FormStartPosition.Manual;
            Text = "frmsalonkayit";
            Load += frmsalonkayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private Label koltuksayisilbl;
        private TextBox salonaditxt;
        private Label salonadilbl;
        private ComboBox cbkoltuksayisi;
        private Button resimyukle;
        private GroupBox groupBox1;
        private FlowLayoutPanel panelsalon;
    }
}