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

        private void txtKartisim_TextChanged(object sender, EventArgs e)
        {
            control.Buyuk_Harfe_Donusturme(txtKartisim);
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            string[] ay = { "01","02","03","04","05","06","07","08","09","10",
                                "11","12","13","14","15","16","17","18","19","20",
                                "21","22","23","24","25","26","27","28","29","30","31"};
            for(int i = 0; i < ay.Length - 1; i++)
            {
                cmbay.Items.Add(ay[i]);
            }

            string[] yıl = { "2022","2023","2024","2025","2026","2027","2028","2029","2030",
                             "2031","2032","2033","2034","2035","2036","2037","2038","2039","2040","2041"};

            for (int i = 0; i < yıl.Length - 1; i++)
            {
                cmbyil.Items.Add(yıl[i]);
            }


        }

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
