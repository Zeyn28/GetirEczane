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
    public partial class EczacıBilgiGuncelle : Form
    {
        public EczacıBilgiGuncelle()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        
        private void btnCık_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string ecztc;
        private void EczacıBilgiGuncelle_Load(object sender, EventArgs e)
        {
            //tc yi id gibi kullanarak bilgileri güncellemek için alanları dolduruyor
            SqlCommand komut = new SqlCommand("Select EczacıAd,EczacıSoyad,EczacıTelNo,EczacıBarkod,EczacıTC,EczacıSifre,EczacıSehir,EczacıAdres,EczaneAd from Eczane where EczacıTC=@q1", bgl.baglan());
            komut.Parameters.AddWithValue("@q1", ecztc);
            SqlDataReader ddr = komut.ExecuteReader();
            while (ddr.Read())
            {
                txtAd.Text = ddr[0].ToString();
                txtSoyad.Text = ddr[1].ToString();
                mskTelefon.Text = ddr[2].ToString();
                mskDiploma.Text = ddr[3].ToString();
                mskTC.Text = ddr[4].ToString();
                txtsifre.Text = ddr[5].ToString();
                comboBox1.Text = ddr[6].ToString();
                rtxtAdres.Text = ddr[7].ToString();
                txtEczaneAd.Text = ddr[8].ToString();
            }
            bgl.baglan().Close();
        }
        public string yeniadsoyad = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //güncelleme kısmı
            SqlCommand ecz_yeni = new SqlCommand("update Eczane set EczacıAd=@y1,EczacıSoyad=@y2,EczacıTelNo=@y3,EczacıBarkod=@y4,EczacıTC=@y5,EczacıSifre=@y6,EczacıSehir=@y7,EczacıAdres=@y8,EczaneAd=@y9 where EczacıTC='" + mskTC.Text + "'", bgl.baglan());
            if (txtAd.Text != "" && txtSoyad.Text != "" && mskTelefon.Text != "" && mskDiploma.Text != "" && mskTC.Text != "" && txtsifre.Text != "" && comboBox1.Text != ""&& rtxtAdres.Text!=""&& txtEczaneAd.Text!="")
            {
                ecz_yeni.Parameters.AddWithValue("@y1", txtAd.Text);
                ecz_yeni.Parameters.AddWithValue("@y2", txtSoyad.Text);
                ecz_yeni.Parameters.AddWithValue("@y3", mskTelefon.Text);
                ecz_yeni.Parameters.AddWithValue("@y4", mskDiploma.Text);
                ecz_yeni.Parameters.AddWithValue("@y5", mskTC.Text);
                ecz_yeni.Parameters.AddWithValue("@y6", txtsifre.Text);
                ecz_yeni.Parameters.AddWithValue("@y7", comboBox1.Text);
                ecz_yeni.Parameters.AddWithValue("@y8", rtxtAdres.Text);
                ecz_yeni.Parameters.AddWithValue("@y9", txtEczaneAd.Text);
                ecz_yeni.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EczacıPaneli.staticlbl.Text = txtAd.Text + " " + txtSoyad.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglan().Close();
        }

       
    }
}
