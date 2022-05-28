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
    public partial class hasta_kayıt_ekleme : Form
    {
        public hasta_kayıt_ekleme()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        Veri_aktarma control = new Veri_aktarma();
        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            hasta_girisi grs = new hasta_girisi();
            grs.Show();
            this.Hide();
        }

        private void btn_kayıt_ol_Click(object sender, EventArgs e)
        {
            if (txtbox_ad.Text != "" && txtbox_soyad.Text != "" && txt_sifre.Text != "" && rtxtbox_adres.Text != "" && mskd_tc.Text != "" && mskd_tel.Text != "" && cmbbox_sehir.Text != "")
            {
                if (txt_sifre.Text.Length >= 4) 
                {
                    SqlCommand komut = new SqlCommand("insert into Hastalar(Ad,Soyad,TelNo,TC,Sehir,Adresi,Sifre) values(@h1,@h2,@h3,@h4,@h5,@h6,@h7)", bgl.baglan());
                    if (control.Regex_sifre(txt_sifre.Text))
                    {
                        SqlCommand tc = new SqlCommand("select TC from Hastalar where TC='" + mskd_tc.Text + "'", bgl.baglan());
                        SqlDataReader tcdr = tc.ExecuteReader();
                        if (tcdr.Read())
                        {
                            MessageBox.Show("TC'niz daha önce kullanılmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            mskd_tc.Text = "";
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@h1", txtbox_ad.Text);
                            komut.Parameters.AddWithValue("@h2", txtbox_soyad.Text);
                            komut.Parameters.AddWithValue("@h3", mskd_tel.Text);
                            komut.Parameters.AddWithValue("@h4", mskd_tc.Text);
                            komut.Parameters.AddWithValue("@h5", cmbbox_sehir.Text);
                            komut.Parameters.AddWithValue("@h6", rtxtbox_adres.Text);
                            komut.Parameters.AddWithValue("@h7", txt_sifre.Text);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kaydınız Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hasta_girisi hg = new hasta_girisi();
                            hg.Show();
                            this.Hide();
                            bgl.baglan().Close();
                        }
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

        private void hasta_kayıt_ekleme_Load(object sender, EventArgs e)
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
