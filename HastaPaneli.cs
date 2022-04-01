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

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ9JK8E;Initial Catalog=getireczane;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            baglanti.Open();

          
            SqlDataAdapter da = new SqlDataAdapter("Select * from Hastalar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HastaPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
