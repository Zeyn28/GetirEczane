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
        Metotlar control = new Metotlar();
        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string tc2;
        private void hasta_bilgi_güncelleme_Load(object sender, EventArgs e)
        {
            txtbox_ad.Focus();
            string[] Sehir = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir",
                "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
                "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari",
                "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli",
                "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon",
                "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman",
                "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
            for (int i = 0; i < Sehir.Length - 1; i++)
            {
                cmbbox_sehir.Items.Add(Sehir[i]);
            }

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
            if (txtbox_ad.Text != "" && txtbox_soyad.Text != "" && txt_sifre.Text != "" && rtxtbox_adres.Text != "" && mskd_tc.Text != "" && mskd_tel.Text != "" && cmbbox_sehir.Text != "") {
                if (txt_sifre.Text.Length >= 4)
                {
                    SqlCommand yeni = new SqlCommand("update Hastalar set Ad=@y1,Soyad=@y2,TelNo=@y3,Sehir=@y4,Adresi=@y5,Sifre=@y6 where TC='" + mskd_tc.Text + "'", bgl.baglan());
                    if (control.Regex_sifre(txt_sifre.Text))
                    {
                        yeni.Parameters.AddWithValue("@y1", txtbox_ad.Text);
                        yeni.Parameters.AddWithValue("@y2", txtbox_soyad.Text);
                        yeni.Parameters.AddWithValue("@y3", mskd_tel.Text);
                        yeni.Parameters.AddWithValue("@y4", cmbbox_sehir.Text);
                        yeni.Parameters.AddWithValue("@y5", rtxtbox_adres.Text);
                        yeni.Parameters.AddWithValue("@y6", txt_sifre.Text);
                        yeni.ExecuteNonQuery();
                        HastaPaneli.statichasta.Text = txtbox_ad.Text + " " + txtbox_soyad.Text;
                        bgl.baglan().Close();
                        MessageBox.Show("Kaydınız Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        HastaPaneli.ComboboxGuncelleme();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz en az 1 tane büyük harf,1 tane küçük harf ve 1 tane rakam içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Şifreniz en az 4 karakterden fazla olmalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtbox_ad_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtbox_ad);
        }

        private void txtbox_soyad_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtbox_soyad);
        }

        private void txtbox_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            control.Harf_kontrolu(e);
        }

        private void txtbox_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            control.Harf_kontrolu(e);
        }
    }
}
