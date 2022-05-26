using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace ProjeDeneme_2
{
    public class Veri_aktarma
    {
        public static string reckod;
        public static string recid;

        public void Buyuk_Harfe_Donusturme(TextBox t)
        {

            if (t.Text.Length == 0)
            {
                MessageBox.Show("Boş girdiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                t.Text = char.ToUpper(t.Text[0]).ToString() + t.Text.Substring(1);
                t.SelectionStart = t.TextLength;
            }

        }
       
       
       
    }
}
