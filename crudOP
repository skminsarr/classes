using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace crudOP
{
    class Program
    {
        static void Main(string[] args)
        {

            string constr = @"Data Source=LAPTOP-3G9KFH97; Initial Catalog=master; Integrated Security=true";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from student", con);
            try
            {
                con.Open();
                //select
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write(dr[0].ToString() + "  " + dr[1].ToString() + " " + dr[2].ToString());
                    Console.WriteLine();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            // insert, update , delete
            //SqlCommand cmd2 = new SqlCommand("insert into student values('25','minsar','howrah')", con);
            SqlCommand cmd2 = new SqlCommand("delete from student where regno='22'", con);
            con.Open();

            if (cmd2.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Data Deleted successfully");
            }
            else
            {
                Console.WriteLine("try again");
            }
            con.Close();
            con.Dispose();
        }
    }
}
