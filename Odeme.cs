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
        Veri_aktarma control = new Veri_aktarma();
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

        private void Odeme_Load(object sender, EventArgs e)
        {
            string[] ay = { "01","02","03","04","05","06","07","08","09","10",
                                "11","12","13","14","15","16","17","18","19","20",
                                "21","22","23","24","25","26","27","28","29","30","31"};
            for(int i = 0; i < ay.Length - 1; i++)
            {
                cmbay.Items.Add(ay[i]);
            }

            string[] yıl = { "22","23","24","25","26","27","28","29","30",
                             "31","32","33","34","35","36","37","38","39","40","41"};

            for (int i = 0; i < yıl.Length - 1; i++)
            {
                cmbyil.Items.Add(yıl[i]);
            }


        }

        private void txtKartisim_Leave(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtKartisim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from oncekisiparisler where OncekisipID='" + sip2 + "'", bgl.baglan());
            komut2.ExecuteNonQuery();
            this.Hide();
        }
    }
}
