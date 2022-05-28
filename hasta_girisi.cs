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

namespace ProjeDeneme_2
{
    public partial class hasta_girisi : Form
    {
        public hasta_girisi()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Hastalar where TC=@g1 Sifre=@g2", bgl.baglan());
            komut.Parameters.AddWithValue("@g1", mskTC.Text);
            komut.Parameters.AddWithValue("@g2", txtSifre.Text);
            SqlDataReader da = komut.ExecuteReader();
            if (da.Read())
            {
                HastaPaneli hstpanel = new HastaPaneli();
                hstpanel.tc = mskTC.Text;
                hstpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!", "Giriş Yapılamadı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTC.Text = "";
                txtSifre.Text = "";
                mskTC.Focus(); 
            }
        }

        private void btnhastaKaydol_Click(object sender, EventArgs e)
        {
            hasta_kayıt_ekleme hstkyt = new hasta_kayıt_ekleme();
            hstkyt.Show();
            this.Hide();

        }

        private void btnhastagiris_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Hastalar where TC=@g1 and Sifre=@g2", bgl.baglan());
            komut.Parameters.AddWithValue("@g1", mskTC.Text);
            komut.Parameters.AddWithValue("@g2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                HastaPaneli hstpanel = new HastaPaneli();
                hstpanel.tc = mskTC.Text;
                hstpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!", "Giriş Yapılamadı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTC.Text = "";
                txtSifre.Text = "";
                mskTC.Focus();
            }
        }

        private void hasta_girisi_Load(object sender, EventArgs e)
        {
            mskTC.Focus();
        }
    }
}
