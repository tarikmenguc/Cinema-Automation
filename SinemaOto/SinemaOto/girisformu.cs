//sql veritabanýna ait kütüphaneyi eklemen ve bunu programa belirtmen gerekiyor
using System.Data;
using System.Data.SqlClient;




namespace SinemaOto
{
    public partial class girisformu : Form
    {
        public girisformu()
        {
            InitializeComponent();
        }
        //connectionstring dediðimiz veritabanýmýzýn yolunu projemize eklememiz gerekiyor ve veri tabanýmýzýn yolunu projemize söylememiz gerekiyor
        //  SqlConnection conn = new SqlConnection(@"Data Source=Veritabanýmýzýn_Yolu;Initial Catalog=Veritabanýmýzýn_adý;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Þifreyi göster
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Þifreyi gizle
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            //Kulllanýcý giriþ iþlemlerini gerçekleþtireceksin
            // select insert update delete komutlarý 
            //select sorgulama
          //  SqlCommand command = new SqlCommand("select*from hangi tablo üzerinde sorgulama iþlmei gerçekleþtireceksem onu belirtiyorum ", conn);
           // þart ya da koþul tümcemiz WHERE idi.
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Users WHERE USERNAME=@username AND USERPASSWORD=@password ",conn);
            command.Parameters.AddWithValue("@username",txtkullaniciadi.Text);
            command.Parameters.AddWithValue("@password",txtPassword.Text);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())// okuma iþlemi baþarýlý ise yani girmiþ olduðun veriler veri tabanýnda mevcut ve eþleþiyor ise yapýlacak iþlemler
            {
               // MessageBox.Show("Giriþ baþarýlý");
               frmanaform frmanaform = new frmanaform();
              frmanaform.kisiadisoyadi = read["NAMESURNAME"].ToString();    
                
                
                frmanaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriþ iþlemi baþarýsýz!!");
            }
           conn.Close();
            txtkullaniciadi.Text = "";
            txtPassword.Text = "";
            txtkullaniciadi.Focus();//imleci konumlandýr.
            
            
            
            //veritabanýna baðlanma iþlemi sorgulama 
        // conn.Open();
        //    if (conn.State==ConnectionState.Open)
        //    {
        //        MessageBox.Show("Baþarýlý!");
        //    }
        //conn.Close();
        }
    }
}
