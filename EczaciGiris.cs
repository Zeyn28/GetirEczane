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
    public partial class EczaciGiris : Form
    {
        public EczaciGiris()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        private void btnEczacıG_Click(object sender, EventArgs e)
        {
            SqlCommand eczkomut = new SqlCommand("select * from Eczane where EczacıTC=@g1 and EczacıSifre=@g2", bgl.baglan());
            eczkomut.Parameters.AddWithValue("@g1", eczmskTC.Text);
            eczkomut.Parameters.AddWithValue("@g2", ecztxtSifre.Text);
            SqlDataReader dr = eczkomut.ExecuteReader();
            if (dr.Read())
            {
                EczacıPaneli eczpanel = new EczacıPaneli();
                eczpanel.ecz_tc = eczmskTC.Text;
                eczpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC no ya da şifre hatalı!", "Giriş Yapılamadı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eczmskTC.Text = "";
                ecztxtSifre.Text = "";
                eczmskTC.Focus();
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            //Form içinde form açarken açılan formun sadece 1 kez açılabilmesi
            EczaciKayit kayit = new EczaciKayit();
            kayit.Name = "deneme";
            if (Application.OpenForms["deneme"] == null) 
            {
                     kayit.Show();
            }
           
           
        }

      
    }
}
