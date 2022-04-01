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
    public partial class SiparisPaneli : Form
    {
        public SiparisPaneli()
        {
            InitializeComponent();
        }
        public string reckod;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SiparisPaneli_Load(object sender, EventArgs e)
        {
            label6.Text = reckod;
            //label 2 sql den label6 kullanılarak çekilecek

        }
    }
}
