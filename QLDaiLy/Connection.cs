using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDaiLy
{
    public class Connection
    {
        public static string GetConnection()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["DoPhuotEntities"].ConnectionString;

            // Cách 2:
            String ConnectionString = @"Data Source=DESKTOP-AQ8E8RK\SQLEXPRESS;initial catalog=QLDaiLy;integrated security=True";
            return ConnectionString;
            
            //SqlConnection con = new SqlConnection(ConnectionString);

            //con.Open();

            //return con;
        }
    }
}