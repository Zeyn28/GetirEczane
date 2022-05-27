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
    public partial class EczaciKayit : Form
    {
        public EczaciKayit()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        Veri_aktarma control = new Veri_aktarma(); //Regex ve regular expressions kullanarak textbox kontrolü 
        private void EczaciKayit_Load(object sender, EventArgs e)
        {
            //şehir comboboxını doldurma
            string[] Sehir = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir",
                "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
                "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", 
                "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", 
                "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", 
                "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", 
                "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
            for(int i = 0; i < Sehir.Length - 1; i++)
            {
                cmbSehir.Items.Add(Sehir[i]);
            }
        }

        private void btnEczacıK_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txteczacisifre.Text != "" && richAdres.Text != "" && mskTC.Text != "" && mskTel.Text != "" && cmbSehir.Text != "" && mskDiploma.Text != "" && txtEczanead.Text != "")
            {
                if (txteczacisifre.Text.Length >= 4) 
                {
                    if (control.regex_sifre(txteczacisifre.Text))
                    {
                        if (dogrulandi.Visible == true)//kontrolden geçerse eczacı kaydı yapılır
                        {
                            SqlCommand tc = new SqlCommand("select EczacıTC from Eczane where EczacıTC='"+mskTC.Text+"'",bgl.baglan());
                            SqlDataReader tcdr = tc.ExecuteReader();
                            if (tcdr.Read())
                            {
                                MessageBox.Show("TC'niz daha önce kullanılmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //update kullanılma sebebi zaten barkodu eczacıya kaydederken kayıt açılmış olması yani aslında burada barkod id gibi kullanılıyor
                                SqlCommand komut = new SqlCommand("update Eczane set EczacıAd=@h1,EczacıSoyad=@h2,EczacıTelNo=@h3,EczacıTC=@h4,EczacıSehir=@h5,EczacıAdres=@h6,EczaneAd=@h8,EczacıSifre=@h9 where EczacıBarkod='" + mskDiploma.Text + "'", bgl.baglan());
                                komut.Parameters.AddWithValue("@h1", txtAd.Text);
                                komut.Parameters.AddWithValue("@h2", txtSoyad.Text);
                                komut.Parameters.AddWithValue("@h3", mskTel.Text);
                                komut.Parameters.AddWithValue("@h4", mskTC.Text);
                                komut.Parameters.AddWithValue("@h5", cmbSehir.Text);
                                komut.Parameters.AddWithValue("@h6", richAdres.Text);
                                komut.Parameters.AddWithValue("@h8", txtEczanead.Text);
                                komut.Parameters.AddWithValue("@h9", txteczacisifre.Text);
                                komut.ExecuteNonQuery();
                                bgl.baglan().Close();
                                MessageBox.Show("Kaydınız Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen geçerli bir diploma barkodu giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from Eczane where EczacıBarkod='"+mskDiploma.Text+"'",bgl.baglan());
            sil.ExecuteNonQuery();

            this.Hide();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            // eczacı diploma barkod kontrolü
            SqlCommand komut = new SqlCommand("Select * from DiplomaBarkodlar where Barkod=@a",bgl.baglan());
            komut.Parameters.AddWithValue("@a", mskDiploma.Text);
            SqlDataReader dr = komut.ExecuteReader();
            bgl.baglan().Close();
            if (dr.Read())
            {
                //alınan barkodun ilgili tabloda eczacının bilgilerine eklenmesi
                SqlCommand komutbarkod = new SqlCommand("insert into Eczane(EczacıBarkod) values (@d)", bgl.baglan());
                komutbarkod.Parameters.AddWithValue("@d", mskDiploma.Text);
                komutbarkod.ExecuteNonQuery();
                bgl.baglan().Close();
                dogrulandi.Visible = true;
                dogrulanmadi.Visible = false;
                //alınan barkodun veritabanından silinmesi
                SqlCommand komutsil = new SqlCommand("Delete from DiplomaBarkodlar where Barkod=@b",bgl.baglan());
                komutsil.Parameters.AddWithValue("@b", mskDiploma.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglan().Close();
                btnKontrol.Enabled = false;
                mskDiploma.ReadOnly=true;
            }
            else
            {
                dogrulanmadi.Visible = true;
                dogrulandi.Visible = false;
                mskDiploma.Text = "";
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

        private void txtEczanead_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtEczanead);
        }
    }

}