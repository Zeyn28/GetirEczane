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
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;

namespace ProjeDeneme_2
{
    public partial class HastaPaneli : Form
    {
        public HastaPaneli()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        public string tc;
        public string sehir;

       
        private void HastaPaneli_Load(object sender, EventArgs e)
        {
            // ad soyad çekme
            label2.Text = tc;
            SqlCommand komut = new SqlCommand("Select (Ad+' '+Soyad) from Hastalar where TC=@q1",bgl.baglan());
            komut.Parameters.AddWithValue("@q1", label2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0].ToString();
            }
            bgl.baglan().Close();

            // Sipariş tablosu için id çekme
            SqlCommand komut2 = new SqlCommand("Select Sehir from Hastalar where TC='"+tc+"'",bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                sehir = dr2[0].ToString();
            }
            bgl.baglan().Close();
            //hastanın şehrindeki eczaneleri comboboxa çekme
            SqlCommand komut3 = new SqlCommand("Select EczaneAd from Eczane where EczacıSehir='"+sehir+"'",bgl.baglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0].ToString());
            }
            bgl.baglan().Close();
            string hastaid="";
            //önceki reçeteler
            SqlCommand komut4 = new SqlCommand("Select HastaID from Hastalar where TC='"+tc+"'",bgl.baglan());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                hastaid = dr4[0].ToString();
            }
            DataTable dt1 = new DataTable();
            SqlDataAdapter komut5 = new SqlDataAdapter("SELECT EczaneAd,ReceteKodu,TeslimTarihi,Ad+' '+Soyad as 'HASTA',SiparişDurumu FROM Siparisler INNER JOIN Eczane ON Siparisler.Eczane=Eczane.EczaneID INNER JOIN Recete ON Siparisler.RecID=Recete.ReceteID INNER JOIN Hastalar ON Siparisler.Hasta=Hastalar.HastaID where Hasta='"+hastaid+"'", bgl.baglan());
            komut5.Fill(dt1);
            dataGridView2.DataSource = dt1;
            bgl.baglan().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrecetegoster_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select İlaç1 as '1.İlaç',İlaç2 as '2.İlaç',İlaç3 as '3.İlaç',İlaç4 as '4.İlaç',İlaç5 as '5.İlaç',İlaç6 as '6.İlaç',İlaç7 as '7.İlaç',İlaç8 as '8.İlaç',İlaç9 as '9.İlaç',İlaç10 as '10.İlaç' from Recete where ReceteKodu='" + txtrecetekodu.Text+"'", bgl.baglan());
            da.Fill(dt1);
            DataTable dt2 = new DataTable();// veritabanından gelen tabloyu düzenlemek için ikinci bir tablo oluşturduk
            dt2.Columns.Add("Reçete");
            for(int i = 0; i < dt1.Rows.Count; i++)// kolon adlarını düzeltiyor
            {
                dt2.Columns.Add("İlaç Adı");
            }
            
                for(int i = 0; i < dt1.Columns.Count; i++) // burada tablo daha iyi gözükmesi için transpoze ediliyor
            {
                DataRow newRow = dt2.NewRow();
                newRow[0] = dt1.Columns[i].Caption;
                for(int j = 0; j < dt1.Rows.Count; j++)
                {
                    newRow[j + 1] = dt1.Rows[j][i];
                    dt2.Rows.Add(newRow);
                }
            }
            

            dataGridView1.DataSource = dt2;
            bgl.baglan().Close();
            SqlCommand fiyat = new SqlCommand("Select Tutar from Recete where ReceteKodu='"+txtrecetekodu.Text+"'",bgl.baglan());
            SqlDataReader drfiy=fiyat.ExecuteReader();
            while (drfiy.Read())
            {
                label9.Text = drfiy[0].ToString();
            }
        }

        private void btn_bilgi_güncelle_Click(object sender, EventArgs e)
        {
            hasta_bilgi_güncelleme hbg = new hasta_bilgi_güncelleme();
            hbg.tc2 = tc;// tc yi id olarak kullarak güncelleme paneline veri çekmek için
            hbg.Show();
        }
        

        private void btnrecetegönder_Click(object sender, EventArgs e)
        {
            string hastaid="", eczacid="", receteid="";

            SqlCommand komut1 = new SqlCommand("Select HastaID from Hastalar where TC='" + tc + "'",bgl.baglan());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                hastaid = dr[0].ToString(); //burada hastanın tc sinden id sine ulaşılıyor
            }
            bgl.baglan().Close();
            SqlCommand komut2 = new SqlCommand("Select EczaneID from Eczane where EczaneAd='" + comboBox1.Text + "'", bgl.baglan());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                eczacid = dr1[0].ToString();// burada sipariş tablosuna reçetenin hangi eczaneden alındığı bilgisi için eczane id sine ulaşılıyor
            }
            bgl.baglan().Close();
            SqlCommand komut3 = new SqlCommand("Select ReceteID from Recete where ReceteKodu='" + txtrecetekodu.Text + "'", bgl.baglan());
            SqlDataReader dr2= komut3.ExecuteReader();
            while (dr2.Read())
            {
                receteid = dr2[0].ToString();//reçete id si çekme
            }
            bgl.baglan().Close();
            // tarih çekme 
            string tarih="";
            SqlCommand tarihcekme = new SqlCommand("SELECT CONVERT (varchar,getdate(),104)", bgl.baglan());
            SqlDataReader date = tarihcekme.ExecuteReader();
            while (date.Read())
            {
                tarih = date[0].ToString();
            }
            // sipariş ekleme
            SqlCommand kmtrecetekodu = new SqlCommand("Select * from Recete where ReceteKodu='"+txtrecetekodu.Text+"'", bgl.baglan());
            SqlDataReader drrecete = kmtrecetekodu.ExecuteReader();
            if (drrecete.Read())
            {
                    SqlCommand komut4 = new SqlCommand("insert into Siparisler (Hasta,Eczane,RecID,TeslimTarihi,SiparişDurumu)values (@s1,@s2,@s3,@s4,@s5)", bgl.baglan());
                    komut4.Parameters.AddWithValue("@s1", hastaid);
                    komut4.Parameters.AddWithValue("@s2", eczacid);
                    komut4.Parameters.AddWithValue("@s3", receteid);
                    komut4.Parameters.AddWithValue("@s4", tarih);
                    komut4.Parameters.AddWithValue("@s5", "False");
                    komut4.ExecuteReader();
                    bgl.baglan().Close();
                    // reçete kodlarını rastgele kodlarla değiştiriyor
                    Random rnd = new Random();
                    string havuz = "ABCDEFGHIJKLMNOPQRSTUWVYZabcdefghijklmnoprstuvyzwq1234567890";
                    string ex = "";
                    for (int i = 0; i < 6; i++)
                    {
                        ex += havuz[rnd.Next(havuz.Length - 1)];
                    }
                    SqlCommand kodguncelleme = new SqlCommand("update Recete set ReceteKodu='" + ex + "'where ReceteID='" + receteid + "'", bgl.baglan());
                    kodguncelleme.ExecuteNonQuery();
                    bgl.baglan().Close();
                Odeme ode = new Odeme();
                ode.Show();
                SqlCommand sipid = new SqlCommand("");

            }
            else
            {
                MessageBox.Show("");
            }
            //formda ÖNCEKİ Reçete tablosunu Güncelleme
            //burada reçete kodu güncelleme hatası var (önceki tablosunda da değişiyor)
            SqlCommand komut6 = new SqlCommand("Select HastaID from Hastalar where TC='" + tc + "'", bgl.baglan());
            SqlDataReader dr3 = komut6.ExecuteReader();
            while (dr3.Read())
            {
                hastaid = dr3[0].ToString();
            }
            DataTable dt1 = new DataTable();
            SqlDataAdapter komut5 = new SqlDataAdapter("SELECT EczaneAd,ReceteKodu,TeslimTarihi,Ad+' '+Soyad as 'HASTA',SiparişDurumu FROM Siparisler INNER JOIN Eczane ON Siparisler.Eczane=Eczane.EczaneID INNER JOIN Recete ON Siparisler.RecID=Recete.ReceteID INNER JOIN Hastalar ON Siparisler.Hasta=Hastalar.HastaID where Hasta='" + hastaid + "'", bgl.baglan());
            komut5.Fill(dt1);
            dataGridView2.DataSource = dt1;
            bgl.baglan().Close();
        }      
    }
}
