namespace SinemaOto
{
    partial class salonlistesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salonlistesi));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblsalonadi = new Label();
            lblkoltuksayisi = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseLeave += ayril;
            pictureBox1.MouseMove += uzerinde;
            // 
            // lblsalonadi
            // 
            lblsalonadi.AutoSize = true;
            lblsalonadi.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblsalonadi.ForeColor = Color.Indigo;
            lblsalonadi.Location = new Point(114, 20);
            lblsalonadi.Name = "lblsalonadi";
            lblsalonadi.Size = new Size(75, 31);
            lblsalonadi.TabIndex = 2;
            lblsalonadi.Text = "label1";
            lblsalonadi.Click += label1_Click;
            lblsalonadi.MouseLeave += ayril;
            lblsalonadi.MouseMove += uzerinde;
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblkoltuksayisi.ForeColor = Color.Gold;
            lblkoltuksayisi.Location = new Point(262, 85);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(66, 28);
            lblkoltuksayisi.TabIndex = 3;
            lblkoltuksayisi.Text = "label2";
            lblkoltuksayisi.Click += label2_Click;
            lblkoltuksayisi.MouseLeave += ayril;
            lblkoltuksayisi.MouseMove += uzerinde;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(123, 83);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 4;
            label1.Text = "Koltuk Sayısı:";
            label1.MouseLeave += ayril;
            label1.MouseMove += uzerinde;
            // 
            // salonlistesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(label1);
            Controls.Add(lblkoltuksayisi);
            Controls.Add(lblsalonadi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "salonlistesi";
            Size = new Size(350, 150);
            Load += salonlistesi_Load;
            MouseLeave += ayril;
            MouseMove += uzerinde;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblsalonadi;
        public Label lblkoltuksayisi;
        public Label label1;
    }
}
