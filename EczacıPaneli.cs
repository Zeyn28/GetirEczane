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
    public partial class EczacıPaneli : Form
    {
        public EczacıPaneli()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniSiparis frm = new YeniSiparis();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            EczacıBilgiGuncelle frmb = new EczacıBilgiGuncelle();
            frmb.tc = label5.Text;
            frmb.Show();
        }

        private void EczacıPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
