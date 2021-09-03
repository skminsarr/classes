using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcedureInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter regno");
            string strreg = Console.ReadLine();
            Console.WriteLine("Enter name");
            string strname = Console.ReadLine();
            Console.WriteLine("Enter address");
            string stradd = Console.ReadLine();

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3G9KFH97; Initial Catalog=master; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "procstud";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@regno", strreg);
            cmd.Parameters.AddWithValue("@name", strname);
            cmd.Parameters.AddWithValue("@addr", stradd);

            SqlParameter paramout = new SqlParameter("@num", SqlDbType.Int);
            paramout.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(paramout);



            try
            {
                con.Open();
                // if (cmd.ExecuteNonQuery() > 0)
                // Console.WriteLine("Data inserted");
                cmd.ExecuteNonQuery();
                Console.WriteLine(paramout.Value);



            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
