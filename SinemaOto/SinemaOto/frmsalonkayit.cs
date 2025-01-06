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
    public partial class frmsalonkayit : Form
    {
        public frmsalonkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resimyukle_Click(object sender, EventArgs e)
        {
            if (salonaditxt.Text != "" && cbkoltuksayisi.Text != "")
            {
                
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_Salonlar (salonadı,koltuksayisi) Values (@p1,@p2)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", salonaditxt.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbkoltuksayisi.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("salon kaydetme işlemi başarılı bir şekilde gerçekleştirildi");
                salonaditxt.Text = "";
                cbkoltuksayisi.Text = "";
                salonaditxt.Focus();
                listegetir();

            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!!!");
            }
        }

        private void frmsalonkayit_Load(object sender, EventArgs e)
        {

            listegetir();
            koltuksayisiolustur();

        }
        void koltuksayisiolustur()
        {
            for (int i = 1; i <= 200; i++)
            {
                cbkoltuksayisi.Items.Add(i);
            }
        }

        void listegetir()
        {
            panelsalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY salonadı ASC", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                salonlistesi arac = new salonlistesi();
                arac.lblsalonadi.Text = oku["salonadı"].ToString();
                arac.lblkoltuksayisi.Text = oku["koltuksayisi"].ToString();
                panelsalon.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {

        }

        private void cbkoltuksayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
