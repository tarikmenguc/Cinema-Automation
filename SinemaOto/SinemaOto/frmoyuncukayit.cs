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

    public partial class frmoyuncukayit : Form
    {
        public frmoyuncukayit()
        {
            InitializeComponent();
        }
        //connectionstring
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimyolu = "";
        private void resimyukle_Click(object sender, EventArgs e)
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
        public string cinsiyet = "0";
        private void yönetmenresim_Click(object sender, EventArgs e)
        {

        }
        public String byas = "00";
        void yashesaplama()
        {
            String dogum = ngun.Value.ToString() + "-" + nay.Value.ToString() + "-" + nyil.Value.ToString();
            DateTime dogumtarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumtarihi.Year;

            byas = yas.ToString();
        }
        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rbkadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void txtbiyo_TextChanged(object sender, EventArgs e)
        {
            int count = txtbiyo.Text.Length;
            int backdown = 300 - count;
            lblkarakter.Text = backdown.ToString();
            if (backdown <= 20)
            {
                lblkarakter.ForeColor = Color.Red;
            }
        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            if (adtext.Text != "" && soyadtext.Text != "" && txtbiyo.Text != "" && resimyolu != "")
            {
                yashesaplama();
                //ToUpper() komutu var olan karakterlerin tümünü büyük harfe çeviren komuttur.
                String adsoyad = adtext.Text.ToString().ToUpper() + " " + soyadtext.Text.ToUpper();
                //insert, update , delete   SqlCommand kayit = new SqlCommand("insert into tabloadi (alanlarımız,) VALUES (değerlerimiz,)",baglanti);    
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into Tbl_Oyuncular (adsoyad,cinsiyet,yas,biyografi,resim) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                kayit.Parameters.AddWithValue("@p1", adsoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", byas);
                kayit.Parameters.AddWithValue("@p4", txtbiyo.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimyolu);
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("oyuncu kayıt işlemi başarııyla gerçekleşti");
                //araç temizleme komudu yazmalısın gerekli
                Aractemizleme();
            }
            else
            {
                MessageBox.Show("lütfen tüm alanları eksiksiz bir şekilde doldurun!!");
            }
            void Aractemizleme()
            {
                adtext.Text = "";
                soyadtext.Text = "";
                txtbiyo.Text = "";
                ngun.Value = 23;
                nay.Value = 10;
                nyil.Value = 2003;
                rberkek.Checked = true;
                rbkadın.Checked = false;
                lblkarakter.Text = "300";
                cinsiyet = "0";
                byas = "00";
                yönetmenresim.ImageLocation = @"C:\Users\M.Tarık MENGÜÇ\Downloads\director.jpg";
                adtext.Focus();
            }

        }

        private void frmoyuncukayit_Load(object sender, EventArgs e)
        {

        }
    }
}
