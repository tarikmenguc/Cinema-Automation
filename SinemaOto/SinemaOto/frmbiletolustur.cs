using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOto
{
    public partial class frmbiletolustur : Form
    {
        public frmbiletolustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblyonetmenara_Click(object sender, EventArgs e)
        {

        }

        private void frmbiletolustur_Load(object sender, EventArgs e)
        {
            filmadigetir();

            biletnoolustur();
        }
        void biletnoolustur()
        {
            //kod oluşturma işlemi gerçekleştireceksin...Random komudunu kullanacaksın
            Random rnd = new Random();
            string karakterler = "0123456234567878234567892342342345623456787856785678";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rnd.Next(karakterler.Length)];
            }
            txtbarkod.Text = kod.ToString();
        }
        void filmadigetir()
        {
            string sorgu = "select DISTINCT filmadı from Tbl_Kontrol ORDER BY filmadı ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                // string gelentarih = rdr["tarih"].ToString();
                cbfilmadi.Items.Add(rdr["filmadı"].ToString());


                //DateTime ftarih = Convert.ToDateTime(gelentarih);
                //DateTime bugun = DateTime.Today;
                //TimeSpan timespan = ftarih - bugun;
                //if (timespan.TotalDays <= 0)
                //{
                //    cbfilmadi.Items.Add(rdr["adı"].ToString());
                //}

            }
            baglanti.Close();

        }

        private void cbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //distinct DISTINC --> veri tabanında kayıtlı olan aynı tür veriler arasında sadece bir tanesini getirir.
            cbtarih.Items.Clear();
            string sorgu = "SELECT DISTINCT tarih FROM Tbl_Kontrol WHERE filmadı=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbtarih.Items.Add(oku["tarih"].ToString());

            }
            baglanti.Close();
        }
        void biletnosorgula()
        {
            string sorgu = "select * from Tbl_Biletler where bkod=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", txtbarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetMetodu();
            }
            else
            {
                biletnoolustur();
                baglanti.Close();
                biletnosorgula();
            }
            baglanti.Close();
        }
        void kaydetMetodu()
        {
            string sorgu = "insert into Tbl_Biletler (bkod,adsoyad,telno,koltukno,filmadi,tarih,saat,salon,islemsaati,tur) Values (@bkod,@adsoyad,@telno,@koltukno,@filmadi,@tarih,@saat,@salon,@islemsaati,@tur)";
            baglanti.Close();
            baglanti.Open();
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("@bkod", txtbarkod.Text.ToString());
            kayit.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@telno", txttelno.Text.ToString());
            kayit.Parameters.AddWithValue("@koltukno", txtkoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
            kayit.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            kayit.Parameters.AddWithValue("@saat", lblseanssec.Text.ToString());
            kayit.Parameters.AddWithValue("@salon", cbsalon.Text.ToString());
            kayit.Parameters.AddWithValue("@islemsaati", DateTime.Now.ToString());
            kayit.Parameters.AddWithValue("@tur", cbbiletturu.Text.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();
            //update - güncelleme komutunu kullanacağız
            string sorgu2 = "UPDATE Tbl_Kontrol SET koltuklar=@numara WHERE filmadı=@filmadı AND tarih=@tarih AND saat=@saat AND salonadı=@salonadı ";
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);
            //if (lblgelenkoltuk.Text.ToString() == "")
            //{
            //    guncelle.Parameters.AddWithValue("@numara",txtkoltuklar.Text.ToString());
            //}
            //else
            //{
            //    guncelle.Parameters.AddWithValue("@numara", lblgelenkoltuk.Text.ToString() + "," + txtkoltuklar.Text.ToString());
            //}
            guncelle.Parameters.AddWithValue("@numara", lblgelenkoltuk.Text.ToString() + "," + txtkoltuklar.Text.ToString());
            guncelle.Parameters.AddWithValue("@filmadı", cbfilmadi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblseanssec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadı", cbsalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("bilet başarılı bir şekilde oluşturuldu");
            salondurumgeldi();
            lblgelenkoltuk.Text = "";
            listegelenkoltuk.Items.Clear();
            lbbelirlenen.Items.Clear();
            txtkoltuklar.Text = "";
        }
        private void btnolustur_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text != "" && txtkoltuklar.Text != "" && txttelno.Text != "" && cbbiletturu.Text != "" && cbfilmadi.Text != "" && cbsalon.Text != "" && cbtarih.Text != "")
            {
                //kayıt işlemleri burada olacak 
                biletnosorgula(); // ve sorgulama sonucunda var olan numara veritabanında kayıtlı değil ise kayıt-ekleme işlemi gerçekleştirilecektir.bu metodun içerisinde işlemler yapılacaktır

            }

            else
            {
                MessageBox.Show("lütfen tüm alanları eksiksiz doldurunuz!");
            }
        }
        void secTiklerimiz()
        {
            txtkoltuklar.Text = "";
            foreach (string item in lbbelirlenen.Items)
            {
                txtkoltuklar.Text += "," + item;

            }
            if (txtkoltuklar.Text.Length > 1)
            {
                txtkoltuklar.Text = txtkoltuklar.Text.Substring(1);
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            //tıklama olayı
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.White) //dolu koltuk
            {
                MessageBox.Show("bu koltuk doludur");
            }
            else
            {
                //boş
                if (btn.ForeColor == Color.Gold)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.images__1_);
                    btn.ForeColor = Color.Indigo;
                    lbbelirlenen.Items.Add(btn.Text);
                    secTiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.indir__2_1);
                    btn.ForeColor = Color.Gold;
                    lbbelirlenen.Items.Remove(btn.Text);
                    secTiklerimiz();
                }


            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void panelseans_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {

            panelseans.Controls.Clear();
            string saatler = "";
            string sorgu = "SELECT DISTINCT saat FROM Tbl_Kontrol WHERE filmadı=@filmadi AND tarih=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["saat"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Indigo;
                rnd.FlatStyle = FlatStyle.Flat;
                rnd.CheckedChanged += new EventHandler(SeansSaatler);

                panelseans.Controls.Add(rnd);
            }

            baglanti.Close();
        }
        void SeansSaatler(object sender, EventArgs e)
        {

            // foreach döngüsünü kullanacaksın.
            foreach (RadioButton arac in panelseans.Controls)
            {

                if (arac.Checked)//bu format seçili ise
                {
                    lblseanssec.Text = arac.Text;
                    cbsalon.Items.Clear();

                    string sorgu = "SELECT DISTINCT salonadı FROM Tbl_Kontrol WHERE filmadı=@filmadi AND tarih=@tarih AND saat=@saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblseanssec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();


                    while (oku.Read())
                    {
                        cbsalon.Items.Add(oku["salonadı"].ToString());

                    }

                    baglanti.Close();

                }
            }


        }

        public void cbsalon_SelectedIndexChanged(object sender, EventArgs e)
        {

            salondurumgeldi();

        }
        void salondurumgeldi()
        {
            string sorgu = "SELECT * FROM Tbl_Salonlar WHERE salonadı=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //lblgelenkoltuk.Text = oku["koltuksayisi"].ToString();
                //if (lblgelenkoltuk.Text.Length > 2)
                //{
                //  lblgelenkoltuk.Text = lblgelenkoltuk.Text.Substring(2);
                //    MessageBox.Show("çalıştı");
                //}
                lblkoltuksayisi.Text = oku["koltuksayisi"].ToString();

            }

            baglanti.Close();
            //seçili olan koltukları veri tabanından çektin
            koltukgetir();
            doldur();
        }
        void doldur()
        {

            koltukpaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblkoltuksayisi.Text);
            for (int i = 1; i < sayi; i++)
            {
                Button btn = new Button();
                //
                if (i <= 8)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 16)
                {
                    btn.Text = "B" + (i-8).ToString();
                    btn.Name = "B" + (i - 8).ToString();
                }
                else if (i <= 24)
                {
                    btn.Text = "C" + (i-16).ToString();
                    btn.Name = "C" + (i - 16).ToString();
                }
                else if (i <= 32)
                {
                    btn.Text = "D" + (i -24).ToString();
                    btn.Name = "D" + (i - 24).ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "E" + (i-32).ToString();
                    btn.Name = "E" + (i-32).ToString();
                }
                else if (i <= 48)
                {
                    btn.Text = "F" + (i-40).ToString();
                    btn.Name = "F" + (i-40).ToString();
                }
                else if (i <= 56)
                {
                    btn.Text = "C" + (i - 48).ToString();
                    btn.Name = "C" + (i - 48).ToString();
                }
                else if (i <= 64)
                {
                    btn.Text = "C" + (i - 56).ToString();
                    btn.Name = "C" + (i - 56).ToString();
                }
                else if (i <= 72)
                {
                    btn.Text = "C" + (i - 64).ToString();
                    btn.Name = "C" + (i - 64).ToString();
                }
                //
                btn.Width = 70;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Gold;
                btn.Click += Btn_Click;
                if (listegelenkoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.indir__2_);
                    //btn.BackColor = Color.Indigo; //koltuk seçili ise
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.indir__2_1);
                    //btn.BackColor = Color.LightBlue;  //koltuk seçili değil ise
                    btn.ForeColor = Color.Gold;
                }

                koltukpaneli.Controls.Add(btn);
            }

        }
        void koltukgetir()
        {
            lblgelenkoltuk.Text = "";
            string sorgu = "SELECT * FROM Tbl_Kontrol WHERE filmadı=@filmadi AND tarih=@tarih AND saat=@saat AND salonadı=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblseanssec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                lblgelenkoltuk.Text += " ," + oku["koltuklar"].ToString();

                if (lblgelenkoltuk.Text.Length > 2)
                {
                    lblgelenkoltuk.Text = lblgelenkoltuk.Text.Substring(2);

                }
                else
                {
                    lblgelenkoltuk.Text = "";
                }
            }

            baglanti.Close();
            koltukayirma();
        }
        void koltukayirma()
        {
            listegelenkoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblgelenkoltuk.Text.ToString();
            sec = no.Split(',');  //hangi karakteri bellirttiysek o karakterde ayırma işlemi yapmaya yarayan komut
            //forereach
            foreach (string bulunan in sec)
            {
                listegelenkoltuk.Items.Add(bulunan);

            }
        }

        private void lblkoltuksayisi_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttelno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgelenkoltuk_Click(object sender, EventArgs e)
        {

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadsoyad.Text = "";
            txttelno.Text = "";
            txtkoltuklar.Text = "";
            cbbiletturu.Text = "";
            cbsalon.Text = "";
            cbtarih.Text = "";
            txtbarkod.Text = "";
            lblgelenkoltuk.Text = "";
            lblkoltuksayisi.Text = "";
            lblseanssec.Text = "";
            cbsalon.Items.Clear();
            cbtarih.Items.Clear();
            cbbiletturu.Items.Clear();
            cbbiletturu.Items.Add("Yetişkin");
            cbbiletturu.Items.Add("Öğrenci");
            biletnoolustur();
            panelseans.Controls.Clear();
            koltukpaneli.Controls.Clear();
            lbbelirlenen.Items.Clear();
            cbfilmadi.Items.Clear();
            listegelenkoltuk.Items.Clear();
            filmadigetir();
            txtadsoyad.Focus();



        }
    }
}

