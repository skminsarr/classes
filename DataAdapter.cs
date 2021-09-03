using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source = LAPTOP-3G9KFH97; Initial Catalog = master ; Integrated Security = true";
            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand("select * from students", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                ad.Fill(dt);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            foreach(DataRow drow in dt.Rows)
            {
                Console.WriteLine(drow[0].ToString() + " " + drow[1].ToString() + " " + drow[2].ToString());

            }

          
        }
    }
}
