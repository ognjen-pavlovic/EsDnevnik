using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace EsDnevnik2022A
{
    class konekcija
    {
        public static SqlConnection connect()
        {
            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-S0KU6N9\\SQLEXPRESS;Initial Catalog=ednevnik;Integrated Security=true");
            return veza;
        }
            
    }
}
