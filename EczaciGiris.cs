﻿using System;
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
    public partial class EczaciGiris : Form
    {
        public EczaciGiris()
        {
            InitializeComponent();
        }

        private void btnEczacıG_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            EczaciKayit kayit = new EczaciKayit();
            kayit.Show();
        }
    }
}
