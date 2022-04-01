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
    public partial class EczaciPaneli : Form
    {
        public EczaciPaneli()
        {
            InitializeComponent();
        }
        
        private void btnSiparisP_Click(object sender, EventArgs e)
        {
            SiparisPaneli sp = new SiparisPaneli();
            sp.reckod = label7.Text;
            sp.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOncekiS_Click(object sender, EventArgs e)
        {
            EczaciOncekiSiparis eos = new EczaciOncekiSiparis();
            eos.etc = eczTc.Text;
            eos.Show();
        }
    }
}
