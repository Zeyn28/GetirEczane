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
    public partial class YeniSiparis : Form
    {
        public YeniSiparis()
        {
            InitializeComponent();
        }

        SQL bgl = new SQL();
        public static string receteid;
        public string onceid;

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string eczid="";
        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            string hstid = ""; eczid="";

            SqlCommand hasta = new SqlCommand("select Hasta from oncekisiparisler where OncekisipID='"+onceid+"'",bgl.baglan());
            SqlDataReader hastadr = hasta.ExecuteReader();
            while (hastadr.Read())
            {
                hstid = hastadr[0].ToString();
            }
            bgl.baglan().Close();

            SqlCommand eczacı = new SqlCommand("select Eczane from oncekisiparisler where OncekisipID='" + onceid + "'", bgl.baglan());
            SqlDataReader eczacıdr = eczacı.ExecuteReader();
            while (eczacıdr.Read())
            {
                eczid = eczacıdr[0].ToString();
            }
            bgl.baglan().Close();


            SqlCommand adres = new SqlCommand("select HastaAdresi from oncekisiparisler where OncekisipID='"+onceid+"'",bgl.baglan());
            SqlDataReader adresdr = adres.ExecuteReader();
            while (adresdr.Read())
            {
                rtxtHastaAdres.Text = adresdr[0].ToString();
            }
            bgl.baglan().Close();

            SqlCommand hastaisim = new SqlCommand("select Ad+' '+Soyad from Hastalar where HastaID='" + hstid + "'", bgl.baglan());
            SqlDataReader hstisimdr = hastaisim.ExecuteReader();
            while (hstisimdr.Read())
            {
                txtHastaAdSoy.Text = hstisimdr[0].ToString();
            }
            bgl.baglan().Close();
            
            //İlaçlar için reçete tablosunu transpoze ettik 
            
            SqlDataAdapter ilac = new SqlDataAdapter("Select İlaç1 as '1.İlaç',İlaç2 as '2.İlaç',İlaç3 as '3.İlaç',İlaç4 as '4.İlaç',İlaç5 as '5.İlaç',İlaç6 as '6.İlaç',İlaç7 as '7.İlaç',İlaç8 as '8.İlaç',İlaç9 as '9.İlaç',İlaç10 as '10.İlaç' from Recete where ReceteID='" + receteid + "'", bgl.baglan());
            DataTable dt1 = new DataTable();
            ilac.Fill(dt1);
            DataTable dt2 = new DataTable();// veritabanından gelen tabloyu düzenlemek için ikinci bir tablo oluşturduk
            dt2.Columns.Add("Reçete");
            for (int i = 0; i < dt1.Rows.Count; i++)// kolon adlarını düzeltiyor
            {
                dt2.Columns.Add("İlaç Adı");
            }

            for (int i = 0; i < dt1.Columns.Count; i++) // burada tablo daha iyi gözükmesi için transpoze ediliyor
            {
                DataRow newRow = dt2.NewRow();
                newRow[0] = dt1.Columns[i].Caption;
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    newRow[j + 1] = dt1.Rows[j][i];
                    dt2.Rows.Add(newRow);
                }
            }
            dataGridView1.DataSource = dt2;
            bgl.baglan().Close();
        }
        public string ecz_kasa = "";
        public string rct_fiyat = "";


        private void btnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand gonder = new SqlCommand("update oncekisiparisler set SiparişDurumuEczane='True'  where OncekisipID='" + onceid + "'", bgl.baglan());
            gonder.ExecuteNonQuery();
            bgl.baglan().Close();
            
            SqlCommand kasa = new SqlCommand("select EczacıKasa from Eczane where EczaneID='" + eczid + "'", bgl.baglan());
            SqlDataReader kasadr = kasa.ExecuteReader();
            while (kasadr.Read())
            {
                ecz_kasa = kasadr[0].ToString();
            }
            bgl.baglan().Close();

            float kasa_tutar = EczacıPaneli.Fiyatregex(ecz_kasa);

            SqlCommand rec_fiyat = new SqlCommand("select Tutar from Recete where ReceteID='" + receteid + "'", bgl.baglan());
            SqlDataReader rec_dr = rec_fiyat.ExecuteReader();
            while (rec_dr.Read())
            {
                rct_fiyat = rec_dr[0].ToString();
            }
            bgl.baglan().Close();
            
            float rec_tutar = EczacıPaneli.Fiyatregex(rct_fiyat);
            kasa_tutar += rec_tutar;
            
            SqlCommand kasaguncelleme = new SqlCommand("update Eczane set EczacıKasa='" + kasa_tutar.ToString() + "' where EczaneID='" + EczacıPaneli.ecz_id + "'", bgl.baglan());
            kasaguncelleme.ExecuteNonQuery();
            bgl.baglan().Close();
            this.Hide();
            MessageBox.Show("Sipariş gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EczacıPaneli.Yeni_siparistable();
            EczacıPaneli.Onceki_siparistable();
            EczacıPaneli.Kasa();
        }
    }
}
