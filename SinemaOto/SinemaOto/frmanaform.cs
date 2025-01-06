using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOto
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public String kisiadisoyadi = "";
        private void frmanaform_Load(object sender, EventArgs e)
        {
            //   MessageBox.Show(kisiadisoyadi);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            frm.ShowDialog();// show

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmyonetmenlistesi frm = new frmyonetmenlistesi();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmoyuncukayit frm = new frmoyuncukayit();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Oyunculistesi frm = new Oyunculistesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmsalonkayit frm = new frmsalonkayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmfilmkayit frm = new frmfilmkayit();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmFilmListe frm = new frmFilmListe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmbiletolustur frm = new frmbiletolustur();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBiletSorgula frm = new FrmBiletSorgula();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmSalonAtama frm = new FrmSalonAtama();    
            frm.ShowDialog();
        }
    }
}
