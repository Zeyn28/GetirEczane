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
    public partial class EczacıPaneli : Form
    {
        public EczacıPaneli()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        public string ecz_tc;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniSiparis frm = new YeniSiparis();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            EczacıBilgiGuncelle frmb = new EczacıBilgiGuncelle();
            frmb.ecztc = ecz_tc;
            frmb.Show();
        }

        private void EczacıPaneli_Load(object sender, EventArgs e)
        {
            //eczacı ad soyad ve tc çekme
            label5.Text = ecz_tc;
            SqlCommand ecz_komut = new SqlCommand("Select (EczacıAd+' '+EczacıSoyad) from Eczane where EczacıTC=@e1", bgl.baglan());
            ecz_komut.Parameters.AddWithValue("@e1", label5.Text);
            SqlDataReader drr = ecz_komut.ExecuteReader();
            while (drr.Read())
            {
                label7.Text = drr[0].ToString();
            }
            bgl.baglan().Close();

        }
    }
}
