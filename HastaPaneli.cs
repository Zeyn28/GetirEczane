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
            label2.Text = tc;
            SqlCommand komut = new SqlCommand("Select (Ad+' '+Soyad) from Hastalar where TC=@q1",bgl.baglan());
            komut.Parameters.AddWithValue("@q1", label2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0].ToString();
            }
            bgl.baglan().Close();
            SqlCommand komut2 = new SqlCommand("Select Sehir from Hastalar where TC='"+tc+"'",bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                sehir = dr2[0].ToString();
            }
            bgl.baglan().Close();
            SqlCommand komut3 = new SqlCommand("Select EczaneAd from Eczane where Sehir='"+sehir+"'",bgl.baglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0].ToString());
            }
            bgl.baglan().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrecetegoster_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Recete where ReceteKodu='"+txtrecetekodu.Text+"'", bgl.baglan());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglan().Close();
        }

        private void btn_bilgi_güncelle_Click(object sender, EventArgs e)
        {
            hasta_bilgi_güncelleme hbg = new hasta_bilgi_güncelleme();
            hbg.tc2 = tc;
            hbg.Show();
        }

        private void btnrecetegönder_Click(object sender, EventArgs e)
        {
            string hastaid="", eczacid="", receteid="";
            SqlCommand komut1 = new SqlCommand("Select HastaID from Hastalar where TC='" + tc + "'",bgl.baglan());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                hastaid = dr[0].ToString();
            }
            bgl.baglan().Close();
            SqlCommand komut2 = new SqlCommand("Select EczaneID from Eczane where EczaneAd='" + comboBox1.Text + "'", bgl.baglan());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                eczacid = dr1[0].ToString();
            }
            bgl.baglan().Close();
            SqlCommand komut3 = new SqlCommand("Select ReceteID from Recete where ReceteKodu='" + txtrecetekodu.Text + "'", bgl.baglan());
            SqlDataReader dr2= komut3.ExecuteReader();
            while (dr2.Read())
            {
                receteid = dr2[0].ToString();
            }
            bgl.baglan().Close();
            SqlCommand komut4 = new SqlCommand("insert into Siparisler (Hasta,Eczane,ReceteKodu)values (@s1,@s2,@s3)",bgl.baglan());
            komut4.Parameters.AddWithValue("@s1", hastaid);
            komut4.Parameters.AddWithValue("@s2", eczacid);
            komut4.Parameters.AddWithValue("@s3", receteid);
            komut4.ExecuteNonQuery();
            bgl.baglan().Close();
        }
    }
}
