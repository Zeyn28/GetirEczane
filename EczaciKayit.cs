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
    public partial class EczaciKayit : Form
    {
        public EczaciKayit()
        {
            InitializeComponent();
        }

        private void EczaciKayit_Load(object sender, EventArgs e)
        {
            string[] Sehir = {"Adana","İstanbul","Ankara","İzmir","Bursa"};
            for(int i = 0; i < Sehir.Length - 1; i++)
            {
                cmbSehir.Items.Add(Sehir[i]);
            }
        }
    }
}
