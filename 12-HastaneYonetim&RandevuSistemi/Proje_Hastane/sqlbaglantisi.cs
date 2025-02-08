using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=HastaneProjeDb;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
