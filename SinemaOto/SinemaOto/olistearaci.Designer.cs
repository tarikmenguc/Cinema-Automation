namespace SinemaOto
{
    partial class olistearaci
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
            lbladi = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Cursor = Cursors.Hand;
            lbladi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladi.Location = new Point(41, 0);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(63, 28);
            lbladi.TabIndex = 0;
            lbladi.Text = "label1";
            lbladi.Click += lbladi_Click;
            lbladi.MouseLeave += ayril;
            lbladi.MouseMove += uzerinde;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 28);
            label1.TabIndex = 1;
            label1.Text = "+";
            // 
            // olistearaci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(lbladi);
            Name = "olistearaci";
            Size = new Size(203, 29);
            Load += olistearaci_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbladi;
        public Label label1;
    }
}
