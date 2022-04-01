using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme_2
{
    public partial class hasta_girisi : Form
    {
        public hasta_girisi()
        {
            InitializeComponent();
        }

        private void btnEczacıG_Click(object sender, EventArgs e)
        {
            HastaPaneli hstpanel = new HastaPaneli();
            hstpanel.Show();
            this.Hide();
        }

        private void btnhastaKaydol_Click(object sender, EventArgs e)
        {
            hasta_kayıt_ekleme hstkyt = new hasta_kayıt_ekleme();
            hstkyt.Show();
            this.Hide();

        }
    }
}
