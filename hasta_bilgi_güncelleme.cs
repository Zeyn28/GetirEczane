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
    public partial class hasta_bilgi_güncelleme : Form
    {
        public hasta_bilgi_güncelleme()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            HastaPaneli hst = new HastaPaneli();
            hst.Show();
            this.Hide();
        }
        public string tc2;
        private void hasta_bilgi_güncelleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Ad,Soyad,TelNo,Sehir,TC,Adresi,Sifre from Hastalar where TC=@q1", bgl.baglan());
            komut.Parameters.AddWithValue("@q1", tc2);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtbox_ad.Text = dr[0].ToString();
                txtbox_soyad.Text = dr[1].ToString();
                mskd_tel.Text = dr[2].ToString();
                cmbbox_sehir.Text = dr[3].ToString();
                mskd_tc.Text = dr[4].ToString();
                rtxtbox_adres.Text = dr[5].ToString();
                txt_sifre.Text = dr[6].ToString();
            }
            bgl.baglan().Close();
        }
        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand yeni = new SqlCommand("update Hastalar set Ad=@y1,Soyad=@y2,TelNo=@y3,Sehir=@y4,Adresi=@y5,Sifre=@y6 where TC='" + mskd_tc.Text + "'",bgl.baglan());
            if (txtbox_ad.Text != "" && txtbox_soyad.Text != "" && txt_sifre.Text != "" && rtxtbox_adres.Text != "" && mskd_tc.Text != "" && mskd_tel.Text != "" && cmbbox_sehir.Text != "")
            {
                yeni.Parameters.AddWithValue("@y1", txtbox_ad.Text);
                yeni.Parameters.AddWithValue("@y2", txtbox_soyad.Text);
                yeni.Parameters.AddWithValue("@y3", mskd_tel.Text);
                yeni.Parameters.AddWithValue("@y4", cmbbox_sehir.Text);
                yeni.Parameters.AddWithValue("@y5", rtxtbox_adres.Text);
                yeni.Parameters.AddWithValue("@y6", txt_sifre.Text);
                yeni.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
