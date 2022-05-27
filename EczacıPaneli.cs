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
using System.IO;
using System.Text.RegularExpressions;

namespace ProjeDeneme_2
{
    public partial class EczacıPaneli : Form
    {
        public EczacıPaneli()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        public string ecz_tc;
        public static string ecz_adsoyad;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static float a = 0;
        public static DataGridView dgw;
        public static DataGridView dgw2;
        public static string ecz_id;
        public static void Yeni_siparistable()
        {
            SQL bgl = new SQL();
            SqlDataAdapter yeni = new SqlDataAdapter("select OncekisipID,Recete,Ad+' '+Soyad as 'Hasta',TeslimTarihi from oncekisiparisler inner join Hastalar on oncekisiparisler.Hasta=Hastalar.HastaID inner join Eczane on oncekisiparisler.Eczane=Eczane.EczaneID where Eczane='" + ecz_id + "' and SiparişDurumuHasta='False'", bgl.baglan());
            DataTable dt1 = new DataTable();
            yeni.Fill(dt1);
            dgw.DataSource = dt1;
            bgl.baglan().Close();
        }
        public static void Onceki_siparistable()
        {
            SQL bgl = new SQL();
            SqlDataAdapter onceki = new SqlDataAdapter("select OncekisipID,Recete,Ad+' '+Soyad as 'Hasta',TeslimTarihi from oncekisiparisler inner join Hastalar on oncekisiparisler.Hasta=Hastalar.HastaID inner join Eczane on oncekisiparisler.Eczane=Eczane.EczaneID where SiparişDurumuHasta='True' and Eczane='" + ecz_id + "' ", bgl.baglan());
            DataTable dt2 = new DataTable();
            onceki.Fill(dt2);
            dgw2.DataSource = dt2;
            bgl.baglan().Close();
        }
        public static float Fiyatregex(string sayi)
        {
            Regex rgx = new Regex(@"\d{0,14}\.\d{0,2}||\d{0,14},\d{0,2}");
            Regex rgx1 = new Regex(@",");
            string sayi2;
            Match m2 = rgx1.Match(sayi);
            Match m = rgx.Match(sayi);
            if (m.Success)
            {
                if (m2.Success)
                {
                    sayi2 = rgx1.Replace(sayi, ".");
                    a = Convert.ToInt64(sayi2);
                    return a;
                }
                else
                {
                    a = Convert.ToInt64(sayi);
                    return a;
                }
            }
            else
            {
                return 0;
            }
        }
        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            EczacıBilgiGuncelle frmb = new EczacıBilgiGuncelle();
            frmb.ecztc = ecz_tc;// tc değişmez olduğu için tcyi id gibi kullanma amacıyla güncelleme formuna gönderme
            frmb.Name = "deneme";
            if (Application.OpenForms["deneme"] == null)
            {
                  frmb.Show();
            }
            
        }
        public static int i=0;
        public static Label staticlbl;
        private void EczacıPaneli_Load(object sender, EventArgs e)
        {
            dgw = dataGridView1;
            dgw2 = dataGridView2;
            // Label sınıf olduğu için referans gönderir
            // bu yüzden iki label ı birbirine eşitlediğimiz de değerleri de eşitleniyor
            staticlbl = label7;
            //eczacı ad soyad ve tc çekme
            label5.Text = ecz_tc;
            SqlCommand ecz_komut = new SqlCommand("Select (EczacıAd+' '+EczacıSoyad) from Eczane where EczacıTC=@e1", bgl.baglan());
            ecz_komut.Parameters.AddWithValue("@e1", label5.Text);
            SqlDataReader drr = ecz_komut.ExecuteReader();
            while (drr.Read())
            {
                ecz_adsoyad = drr[0].ToString();
            }
            label7.Text = ecz_adsoyad;
            bgl.baglan().Close();
            string eczid ="";
            SqlCommand kmt = new SqlCommand("select EczaneID from Eczane where EczacıTC='"+ecz_tc+"'",bgl.baglan());
            SqlDataReader drecz = kmt.ExecuteReader();
            while (drecz.Read())
            {
                eczid = drecz[0].ToString();
            }
            ecz_id = eczid;
            bgl.baglan().Close();

            //yeni siparişler
            SqlDataAdapter yeni = new SqlDataAdapter("select OncekisipID,Recete,Ad+' '+Soyad as 'Hasta',TeslimTarihi from oncekisiparisler inner join Hastalar on oncekisiparisler.Hasta=Hastalar.HastaID inner join Eczane on oncekisiparisler.Eczane=Eczane.EczaneID where Eczane='" + eczid + "' and SiparişDurumuEczane='True' and SiparişDurumuHasta='False'", bgl.baglan());
            DataTable dt1 = new DataTable();
            yeni.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglan().Close();

            //önceki siparişler

            SqlDataAdapter onceki = new SqlDataAdapter("select OncekisipID,Recete,Ad+' '+Soyad as 'Hasta',TeslimTarihi from oncekisiparisler inner join Hastalar on oncekisiparisler.Hasta=Hastalar.HastaID inner join Eczane on oncekisiparisler.Eczane=Eczane.EczaneID where SiparişDurumuEczane='True' and SiparişDurumuHasta='True' and Eczane='" + eczid + "' ", bgl.baglan());
            DataTable dt2 = new DataTable();
            onceki.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.baglan().Close();
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniSiparis frm = new YeniSiparis();
            frm.onceid=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.receteid=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.Name = "deneme";
            if (Application.OpenForms["deneme"] == null)
            {
                       frm.Show();
            }
            
        }
        
    }
}
