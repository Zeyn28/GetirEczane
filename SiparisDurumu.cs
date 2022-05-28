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
    public partial class SiparisDurumu : Form
    {
        public SiparisDurumu()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        public string tc;
        public string hasid="";
        public static DataGridView dtgr;


        private void HastaReceteler_Load(object sender, EventArgs e)
        {
            SqlCommand hastaid = new SqlCommand("select HastaID from Hastalar where TC='"+tc+"'",bgl.baglan());
            SqlDataReader drid = hastaid.ExecuteReader();
            while (drid.Read())
            {
                hasid = drid[0].ToString();
            }
            SqlDataAdapter da = new SqlDataAdapter("select OncekiReceteKod as 'Reçete Kodu',TeslimTarihi as 'Teslim Tarihi',OncekisipID from oncekisiparisler where Hasta='"+hasid+"' and SiparişDurumuHasta='False'",bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dtgr = dataGridView1;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string durum="";
            string sipaid = dtgr.CurrentRow.Cells[2].Value.ToString();
            SqlCommand sipdurum = new SqlCommand("select SiparişDurumuEczane from oncekisiparisler where Hasta='"+hasid+"'",bgl.baglan());
            SqlDataReader dr = sipdurum.ExecuteReader();
            while (dr.Read())
            {
                durum = dr[0].ToString();
            }
            if (durum == "True")
            {

                DialogResult result = MessageBox.Show("Siparişiniz yola çıkmıştır. Lütfen teslim edildiğinde \"OK\"a basın.", "Sipariş Durumu", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    SqlCommand ctr = new SqlCommand("update oncekisiparisler set SiparişDurumuHasta='True' where OncekisipID='"+sipaid+"'",bgl.baglan());
                    ctr.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Siparişiniz henüz gönderilmedi.","Sipariş Durumu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
