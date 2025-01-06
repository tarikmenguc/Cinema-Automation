using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaOto
{
    public partial class yonetmenlistesi : UserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        public yonetmenlistesi()
        {
            InitializeComponent();
        }

        private void frmyonetmenlistesi_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblıd.Text);
            SqlDataReader oku = komut.ExecuteReader();

            baglanti.Close();



        }

        private void lblıd_Click(object sender, EventArgs e)
        {

        }

        private void resimyukle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblıd.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("biyografi:" + oku["biyografi"].ToString(), oku["adsoyad"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler Where ID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", lblıd.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show(lbladsoyad.Text + "kişisine ait kayıt başarılı bir şekilde silinmiştir");
            this.Hide(); //ussercontrol aracımızı gizlemiş oluyoruz!!! ama tüm araçlar gizlenmeyecektirr
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
