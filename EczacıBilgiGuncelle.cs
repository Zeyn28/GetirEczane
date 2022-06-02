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
        Metotlar control = new Metotlar();
        private void btnCık_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string ecztc;
        private void EczacıBilgiGuncelle_Load(object sender, EventArgs e)
        {
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
                comboBox1.Items.Add(Sehir[i]);
            }
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
                if (txtsifre.Text.Length >= 4)
                {
                    if (control.Regex_sifre(txtsifre.Text))
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
                        bgl.baglan().Close();
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

        private void txtAd_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtAd);
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtSoyad);
        }

        private void txtEczaneAd_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtEczaneAd);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            control.Harf_kontrolu(e);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            control.Harf_kontrolu(e);
        }

        private void txtEczaneAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            control.Harf_kontrolusayili(e);
        }
    }
}