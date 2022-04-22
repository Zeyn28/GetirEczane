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
        private void EczaciKayit_Load(object sender, EventArgs e)
        {
            string[] Sehir = {"Adana","İstanbul","Ankara","İzmir","Bursa"};
            for(int i = 0; i < Sehir.Length - 1; i++)
            {
                cmbSehir.Items.Add(Sehir[i]);
            }
        }

        private void btnEczacıK_Click(object sender, EventArgs e)
        {

            if (txtAd.Text != "" && txtSoyad.Text != "" && txteczacisifre.Text != "" && richAdres.Text != "" && mskTC.Text != "" && mskTel.Text != "" && cmbSehir.Text != "" && mskDiploma.Text != "" && txtEczanead.Text != "")
            {
                if (dogrulandi.Visible == true)
                {
                        SqlCommand komut = new SqlCommand("update Eczane set EczacıAd=@h1,EczacıSoyad=@h2,EczacıTelNo=@h3,EczacıTC=@h4,EczacıSehir=@h5,EczacıAdres=@h6,EczaneAd=@h8,EczacıSifre=@h9 where EczacıBarkod='"+ mskDiploma.Text+"'", bgl.baglan());
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
                else
                {
                    MessageBox.Show("Lütfen geçerli bir diploma barkodu giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from DiplomaBarkodlar where Barkod=@a",bgl.baglan());
            komut.Parameters.AddWithValue("@a", mskDiploma.Text);
            SqlDataReader dr = komut.ExecuteReader();
            bgl.baglan().Close();
            if (dr.Read())
            {
                SqlCommand komutbarkod = new SqlCommand("insert into Eczane(EczacıBarkod) values (@d)", bgl.baglan());
                komutbarkod.Parameters.AddWithValue("@d", mskDiploma.Text);
                komutbarkod.ExecuteNonQuery();
                bgl.baglan().Close();
                dogrulandi.Visible = true;
                dogrulanmadi.Visible = false;
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
    }
}