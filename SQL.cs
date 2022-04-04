using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProjeDeneme_2
{
    class SQL
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ9JK8E;Initial Catalog=getireczane;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
