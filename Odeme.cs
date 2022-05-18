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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SQL bgl = new SQL();
        public string tutar;
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand kontrol = new SqlCommand("select * from Kartlar where Kartisim='"+txtKartisim.Text+"' and Kartno='"+mtxtKartno.Text+"' and Sontarih='"+cmbay.Text+"/"+cmbyil.Text+"' and Guvenlikkod='"+mtxtGuvenlikkod.Text+"'",bgl.baglan());
            SqlDataReader dr = kontrol.ExecuteReader();
            if (dr.Read()!=true)
            {
                MessageBox.Show("Bilgileriniz yanlış. Kontrol ediniz.", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Siparişiniz başarıyla oluşturuldu.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
        }

        public int sip,sip2;

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("delete from Siparisler where SiparisID='"+sip+"'",bgl.baglan());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("delete from oncekisiparisler where OncekisipID='" + sip2 + "'", bgl.baglan());
            komut2.ExecuteNonQuery();
            this.Hide();
        }
    }
}
