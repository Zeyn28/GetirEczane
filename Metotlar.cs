using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace ProjeDeneme_2
{
    public class Metotlar
    {
        public static string reckod;
        public static string recid;
        
        public static void ReceteKodu_Kontrolu(KeyPressEventArgs e)
        {
            //alt gr ile yapılan kombinasyonlar ascii tablosunda yok o yüzden tek tek kontrol ediyoruz
            //ayrıca diğer ifler de diğer noktalama işaretleri için
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' ||
                e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || 
                e.KeyChar == 'ß'|| e.KeyChar == '´')
            {
                e.Handled = true;
            }
            //alttaki fonksiyondan farkı boşluk tuşuna basmayı da engelliyor 
            if ((int)e.KeyChar >= 32 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 126)
            {
                e.Handled = true;
            }
        }
        public void Harf_kontrolu(KeyPressEventArgs e)
        {
            //rakam girilmemesi için
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            //alt gr ile yapılan kombinasyonlar ascii tablosunda yok o yüzden tek tek kontrol ediyoruz
            //ayrıca diğer ifler de diğer noktalama işaretleri için
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' ||
                e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || 
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 126)
            {
                e.Handled = true;
            }
        }
        public void Harf_kontrolusayili(KeyPressEventArgs e)
        {
            //rakam girilmemesi için
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            //alt gr ile yapılan kombinasyonlar ascii tablosunda yok o yüzden tek tek kontrol ediyoruz
            //ayrıca diğer ifler de diğer noktalama işaretleri için
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' ||
                e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if((int)e.KeyChar>=58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 126)
            {
                e.Handled = true;
            }
        }
        public void Buyuk_Harfe_Donusturme(TextBox t)
        {
            string yeni_kelime = "";
            //burada eğer kullanıcı sonda boşluk kullanırsa for içindeki kod hata verdiğinden trim ediyoruz
            string[] kelimeler = t.Text.TrimEnd(' ').Split(' ');
            if (t.Text != "")
            {   
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    yeni_kelime += kelimeler[i].Substring(0, 1).ToUpper() + kelimeler[i].Substring(1, kelimeler[i].Length - 1).ToLower() + " ";

                }
                t.Text = yeni_kelime.TrimEnd(' ');
            }
        }

        public bool Regex_sifre(string str)
        {
            Regex rgx = new Regex(@"([a-z]+[A-Z]+[0-9]+) || ([A-Z]+[a-z]+[0-9]+)||
            ([0-9]+[A-Z]+[a-z]+)||([A-Z]+[0-9]+[a-z]+)||
            ([a-z]+[0-9]+[A-Z]+)||([0-9]+[a-z]+[A-Z]+)");
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
