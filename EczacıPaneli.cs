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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            EczacıBilgiGuncelle frmb = new EczacıBilgiGuncelle();
            frmb.ecztc = ecz_tc;// tc değişmez olduğu için tcyi id gibi kullanma amacıyla güncelleme formuna gönderme
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
            string eczid="";
            SqlCommand kmt = new SqlCommand("select EczaneID from Eczane where EczacıTC='"+ecz_tc+"'",bgl.baglan());
            SqlDataReader drecz = kmt.ExecuteReader();
            while (drecz.Read())
            {
                eczid = drecz[0].ToString();
            }

            //yeni siparişler
            SqlDataAdapter yeni = new SqlDataAdapter("select OncekisipID as 'ID',Recete,Ad+' '+Soyad as 'Hasta',EczaneAd as 'Eczane Adı',TeslimTarihi from oncekisiparisler inner join Hastalar on oncekisiparisler.Hasta=Hastalar.HastaID inner join Eczane on oncekisiparisler.Eczane=Eczane.EczaneID where Eczane='" + eczid + "' and SiparişDurumu='" + false + "'", bgl.baglan());
            DataTable dt1 = new DataTable();
            yeni.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglan().Close();

        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniSiparis frm = new YeniSiparis();
            //FileStream fs = new FileStream(@"C: \Users\w10\Desktop\recetekodu.txt",FileMode.Open,FileAccess.Read);
            //StreamReader sr=new StreamReader(fs);
            //string recid = sr.ReadLine();
            frm.onceid=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.receteid=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.Show();
        }
        
    }
}
