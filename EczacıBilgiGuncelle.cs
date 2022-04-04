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
    public partial class EczacıBilgiGuncelle : Form
    {
        public EczacıBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string tc;
        private void btnCık_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EczacıBilgiGuncelle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tc;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
