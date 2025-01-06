namespace SinemaOto
{
    partial class OyuncuListeleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListeleri));
            silbtn = new Button();
            resimyukle = new Button();
            pbresimdetay = new PictureBox();
            lblıd = new Label();
            lbladsoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).BeginInit();
            SuspendLayout();
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.Indigo;
            silbtn.Cursor = Cursors.Hand;
            silbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            silbtn.ForeColor = Color.CadetBlue;
            silbtn.Location = new Point(500, 92);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(85, 41);
            silbtn.TabIndex = 23;
            silbtn.Text = "SİL";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // resimyukle
            // 
            resimyukle.BackColor = Color.Indigo;
            resimyukle.Cursor = Cursors.Hand;
            resimyukle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            resimyukle.ForeColor = Color.GhostWhite;
            resimyukle.Location = new Point(375, 92);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(122, 41);
            resimyukle.TabIndex = 22;
            resimyukle.Text = "DETAY";
            resimyukle.UseVisualStyleBackColor = false;
            resimyukle.Click += resimyukle_Click;
            // 
            // pbresimdetay
            // 
            pbresimdetay.Image = (Image)resources.GetObject("pbresimdetay.Image");
            pbresimdetay.Location = new Point(12, 10);
            pbresimdetay.Name = "pbresimdetay";
            pbresimdetay.Size = new Size(125, 122);
            pbresimdetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresimdetay.TabIndex = 21;
            pbresimdetay.TabStop = false;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblıd.ForeColor = Color.Indigo;
            lblıd.Location = new Point(163, 74);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(75, 31);
            lblıd.TabIndex = 20;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lbladsoyad.ForeColor = Color.Indigo;
            lbladsoyad.Location = new Point(163, 10);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(75, 31);
            lbladsoyad.TabIndex = 19;
            lbladsoyad.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 135);
            panel1.TabIndex = 18;
            // 
            // OyuncuListeleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(silbtn);
            Controls.Add(resimyukle);
            Controls.Add(pbresimdetay);
            Controls.Add(lblıd);
            Controls.Add(lbladsoyad);
            Controls.Add(panel1);
            Name = "OyuncuListeleri";
            Size = new Size(587, 135);
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button silbtn;
        private Button resimyukle;
        public PictureBox pbresimdetay;
        public Label lblıd;
        public Label lbladsoyad;
        private Panel panel1;
    }
}
