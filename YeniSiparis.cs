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
        public string recetekodu;
        public string receteid;
        public string onceid;

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            string hstid = "";
            SqlCommand hasta = new SqlCommand("select Hasta from oncekisiparisler where OncekisipID='"+onceid+"'",bgl.baglan());
            SqlDataReader hastadr = hasta.ExecuteReader();
            while (hastadr.Read())
            {
                hstid = hastadr[0].ToString();
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
            SqlDataAdapter ilac = new SqlDataAdapter("select * from Recete where ReceteID='"+receteid+ "'",bgl.baglan());
            DataTable dt1 = new DataTable();
            ilac.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglan().Close();
        }
    }
}
