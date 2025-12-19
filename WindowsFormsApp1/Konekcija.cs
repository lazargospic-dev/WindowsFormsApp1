using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApp1
{

        class konekcija
        {
            static public SqlConnection connect()
            {
                string CS;
                CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
                SqlConnection konekcija = new SqlConnection(CS);
                return konekcija;

            }

        }
    
}
