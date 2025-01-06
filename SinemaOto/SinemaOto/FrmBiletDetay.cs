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
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        public string biletno = "";
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblbiletno.Text = biletno;
            lblbiletno2.Text = biletno;
            barkodnolustur();
            bilgigetir();
        }
        void bilgigetir()
        {
            string sorgu = "select * from Tbl_Biletler where bkod=@kod";
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletno);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblfilmadi.Text = oku["filmadi"].ToString();
                lblfilmadi2.Text = oku["filmadi"].ToString();
                lbltelno.Text = oku["telno"].ToString() ;
                lbladsoyad.Text = oku["adsoyad"].ToString();
                lblbiletturu.Text = oku["tur"].ToString();
                lblsalonadi.Text = oku["salon"].ToString();
                lblsalon2.Text = oku["salon"].ToString();
                lbltarih2.Text = oku["tarih"].ToString()+" "+ oku["saat"].ToString();
                lbltarihsaat.Text = oku["tarih"].ToString() + " " + oku["saat"].ToString(); ;
                lblislemtarihi.Text = oku["islemsaati"].ToString();
                lblkoltuklar.Text = oku["koltukno"].ToString();
                lblkoltuklar2.Text = oku["koltukno"].ToString();
            }
            baglanti.Close();
        }
        void barkodnolustur()
        {
            //kod oluşturma işlemi gerçekleştireceksin...Random komudunu kullanacaksın
            Random rnd = new Random();
            string karakterler = "0123456234567878234567892342342345623456787856785678";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rnd.Next(karakterler.Length)];
            }
            lblbarkod1.Text = kod.ToString();
            lblbarkod2.Text = kod.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblfilmadi_Click(object sender, EventArgs e)
        {

        }
    }
}
