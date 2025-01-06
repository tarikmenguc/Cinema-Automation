using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOto
{
    public partial class frmfilmkayit : Form
    {
        public frmfilmkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verilerisil();
        }
        void verilerisil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();   
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void yönetmenresim_Click(object sender, EventArgs e)
        {

        }
        public string resimyolu = "";
        private void button2_Click(object sender, EventArgs e)
        {





            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim seçme ekranı";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|ALL FILES|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlmeini bu alanda ya da bu kısımda gerçekleştireceğiz
                yönetmenresim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int count = txtfilmdetay.Text.Length;
            int backdown = 300 - count;
            lblkarakter.Text = backdown.ToString();
            if (backdown <= 20)
            {
                lblkarakter.ForeColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmfilmkayit_Load(object sender, EventArgs e)
        {
            ylistesigetir();
            olistesigetir();
            bugununtarihi();

        }
        void bugununtarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;

        }
        void ylistesigetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY adsoyad ASC";
            fyonpaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                ylistearaci arac = new ylistearaci();
                arac.lbladi.Text = rdr["adsoyad"].ToString();
                fyonpaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
        void olistesigetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY adsoyad ASC";
            foyuncupanel.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                olistearaci arac = new olistearaci();
                arac.lbladi.Text = rdr["adsoyad"].ToString();
                foyuncupanel.Controls.Add(arac);

            }
            baglanti.Close();


        }

        private void foyuncupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fyonpaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            yonetmenara();
        }

        private void txtoyuncuara_TextChanged(object sender, EventArgs e)
        {
            oyuncuara();
        }
        void oyuncuara()
        {

            string sorgu = "select * from Tbl_Oyuncular Where adsoyad LIKE '%" + txtoyuncuara.Text + "%' collate Turkish_CI_AS ORDER  BY adsoyad ASC ";
            foyuncupanel.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                olistearaci arac = new olistearaci();
                arac.lbladi.Text = rdr["adsoyad"].ToString();
                foyuncupanel.Controls.Add(arac);

            }
            baglanti.Close();
        }
        void yonetmenara()
        {

            string sorgu = "select * from Tbl_Yonetmenler Where adsoyad LIKE '%" + txtarayonetmen.Text + "%' ORDER  BY adsoyad ASC ";
            fyonpaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                olistearaci arac = new olistearaci();
                arac.lbladi.Text = rdr["adsoyad"].ToString();
                fyonpaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void lblaksiyon_Click(object sender, EventArgs e)
        {
            if (lblaksiyon.ForeColor == Color.Indigo)
            {
                lblaksiyon.ForeColor = Color.Gold;

            }
            else
            {
                lblaksiyon.ForeColor = Color.Indigo;
            }
        }

        private void lblkorku_Click(object sender, EventArgs e)
        {
            if (lblkorku.ForeColor == Color.Indigo)
            {
                lblkorku.ForeColor = Color.Gold;

            }
            else
            {
                lblkorku.ForeColor = Color.Indigo;
            }
        }

        private void lblask_Click(object sender, EventArgs e)
        {
            if (lblask.ForeColor == Color.Indigo)
            {
                lblask.ForeColor = Color.Gold;

            }
            else
            {
                lblask.ForeColor = Color.Indigo;
            }
        }

        private void lbldrama_Click(object sender, EventArgs e)
        {
            if (lbldrama.ForeColor == Color.Indigo)
            {
                lbldrama.ForeColor = Color.Gold;

            }
            else
            {
                lbldrama.ForeColor = Color.Indigo;
            }
        }

        private void lblgerilim_Click(object sender, EventArgs e)
        {
            if (lblgerilim.ForeColor == Color.Indigo)
            {
                lblgerilim.ForeColor = Color.Gold;

            }
            else
            {
                lblgerilim.ForeColor = Color.Indigo;
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {
            if (lblaltyazili.ForeColor == Color.Indigo)
            {
                lblaltyazili.ForeColor = Color.Gold;

            }
            else
            {
                lblaltyazili.ForeColor = Color.Indigo;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (lblolumsuzicerikler.ForeColor == Color.Indigo)
            {
                lblolumsuzicerikler.ForeColor = Color.Gold;

            }
            else
            {
                lblolumsuzicerikler.ForeColor = Color.Indigo;
            }
        }

        private void lblkrsdt_Click(object sender, EventArgs e)
        {
            if (lblkrsdt.ForeColor == Color.Indigo)
            {
                lblkrsdt.ForeColor = Color.Gold;

            }
            else
            {
                lblkrsdt.ForeColor = Color.Indigo;
            }
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            if (lbl18.ForeColor == Color.Indigo)
            {
                lbl18.ForeColor = Color.Gold;

            }
            else
            {
                lbl18.ForeColor = Color.Indigo;
            }
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (lbl7.ForeColor == Color.Indigo)
            {
                lbl7.ForeColor = Color.Gold;

            }
            else
            {
                lbl7.ForeColor = Color.Indigo;
            }
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            if (lbl13.ForeColor == Color.Indigo)
            {
                lbl13.ForeColor = Color.Gold;

            }
            else
            {
                lbl13.ForeColor = Color.Indigo;
            }
        }

        private void lblgenelizleyici_Click(object sender, EventArgs e)
        {
            if (lblgenelizleyici.ForeColor == Color.Indigo)
            {
                lblgenelizleyici.ForeColor = Color.Gold;

            }
            else
            {
                lblgenelizleyici.ForeColor = Color.Indigo;
            }
        }

        private void lbltrdblj_Click(object sender, EventArgs e)
        {
            if (lbltrdblj.ForeColor == Color.Indigo)
            {
                lbltrdblj.ForeColor = Color.Gold;

            }
            else
            {
                lbltrdblj.ForeColor = Color.Indigo;
            }
        }

        private void lblingilizce_Click(object sender, EventArgs e)
        {
            if (lblingilizce.ForeColor == Color.Indigo)
            {
                lblingilizce.ForeColor = Color.Gold;

            }
            else
            {
                lblingilizce.ForeColor = Color.Indigo;
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vizyontarihihesapla();
        }
        string vtarih = "";
        string durum = "0";
        void vizyontarihihesapla()
        {
            vtarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
            DateTime dvtarih = Convert.ToDateTime(vtarih); //bunu kullanma sebebin tarih zaman formatına çevirmek için
            DateTime buguntarihi = DateTime.Today;

            //timespan --> var olan iki tarih arasındaki gün ay yıl saat vs gibi konuları,sayısal verileri belirlemeey yarıyor
            TimeSpan tspan = dvtarih - buguntarihi;
            if (tspan.TotalDays < 0)
            {
                // iki tarih arasında bulunan fark negatif ise ne olacak.
                MessageBox.Show("geçmiş tarihe ait film eklenmesi yapılamaz");
                bugununtarihi();
            }
            else if (tspan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtfilmadi.Text.ToUpper() + " " + " filmi bugün vizyonda");

            }
            else
            {
                durum = "0";
                MessageBox.Show(txtfilmadi.Text.ToUpper() + " " + tspan.TotalDays.ToString() + "gün sonra vizyona girecektir!");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();
        }
        string yonetmen = "";
        string oyuncu = "";

        void secilenyonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler Where tur='yonetmen'";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            // komut.Parameters.AddWithValue("@p1","yonetmen");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())// if ise burası tek bir seçim yapar  o yüzden while kullanmak lazım 
            {
                yonetmen += " ," + oku["kisi"].ToString();
            }
            baglanti.Close();



        }

        void secilenoyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler Where tur='oyuncu'";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            // komut.Parameters.AddWithValue("@p1","yonetmen");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())// if ise burası tek bir seçim yapar  o yüzden while kullanmak lazım 
            {
                oyuncu += " ," + oku["kisi"].ToString();
            }
            baglanti.Close();



        }
        void temizlememetodu()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            verilerisil();
            ylistesigetir();
            olistesigetir();
            bugununtarihi();
        }
        private void resimyukle_Click(object sender, EventArgs e)
        {
            // insert into deyimini kullanarak verileri verileri veri tabanına kaydetme işlemi gerçekleştireceğiz.
            //input kontrolu sağlayaccağız
            secilenoyuncu();
            tur();
            ozellik();
            bicim();
            secilenyonetmen();

            if (txtfilmadi.Text!="" && txtfilmdetay.Text!="" && yonetmen!="" && oyuncu!="" && resimyolu!="" && vtarih!="" && secilenbicim!="" &&secilenozellik!="" )
            {
               // eğer alanlarımız dolu ise ne olacak

                string sorgu = "insert into Tbl_Filmler (adı,turu,ozellikler,bicimi,yonetmen,oyuncu,detay,afis,tarih,durum) VALUES (@adı,@turu,@ozellikler,@bicimi,@yonetmen,@oyuncu,@detay,@afis,@tarih,@durum)";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adı", txtfilmadi.Text.ToUpper());
                if (secilentur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@turu", secilentur.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@turu", secilentur);
                }

                if (secilenozellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@ozellikler", secilenozellik.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@ozellikler", secilenozellik);
                }

                if (secilenbicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@bicimi", secilenbicim.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@bicimi", secilenbicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@yonetmen", yonetmen.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@yonetmen", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@oyuncu", oyuncu.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@oyuncu", oyuncu);
                }

                //  komut.Parameters.AddWithValue("@yonetmen",yonetmen);
                // komut.Parameters.AddWithValue("@oyuncu",oyuncu);
                komut.Parameters.AddWithValue("@detay", txtfilmdetay.Text.ToUpper());
                komut.Parameters.AddWithValue("@afis", resimyolu);
                komut.Parameters.AddWithValue("@tarih", vtarih);
                komut.Parameters.AddWithValue("@durum", durum);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film Kaydı Başarılı Bir Şekilde Eklendi!");
                temizlememetodu();
        
                }
            else
            {
                // alanlar boş ise ne olacak
                MessageBox.Show("lütfen boş alan brakmayınız");
            }

            //Geçici alanlarımız - daha sonradan değiştireceksin

           



        }
        string secilentur = "";
        string secilenozellik = "";
        string secilenbicim = "";
        void tur()
        {

            foreach (Control arac in grbtur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Indigo)
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilentur += "," + arac.Text.ToString();
                    }
                }
            }

        }
        void ozellik()
        {

            foreach (Control arac in grbozellik.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Indigo)
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilenozellik += "," + arac.Text.ToString();
                    }
                }
            }

        }
        void bicim()
        {

            foreach (Control arac in grbbicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Indigo)
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilenbicim += "," + arac.Text.ToString();
                    }
                }
            }

        }

       
    }
}
