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

            string yeni_kelime = "";
            string[] kelimeler = t.Text.Split(' ');
            if (t.Text != "")
            {
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    yeni_kelime += kelimeler[i].Substring(0, 1).ToUpper() + kelimeler[i].Substring(1, kelimeler[i].Length - 1).ToLower() + " ";

                }
                t.Text = yeni_kelime.TrimEnd(' ');
            }
        }
        public bool regex_sifre(string str)
        {
            Regex rgx = new Regex(@"[a-z]+[A-Z]+[0-9]+");
            Match m = rgx.Match(str);
            if (m.Success)
            {
                return true;  
            }
            else
            {
                return false;
            }
        }


    }
}
