using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UserInputDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter registration number");
            string strreg = Console.ReadLine();
            Console.WriteLine("Enter the name");
            string strnm = Console.ReadLine();
            Console.WriteLine("Enter address");
            string stradd = Console.ReadLine();
            string constr = @"Data Source = LAPTOP-3G9KFH97; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" + strreg + "','" + strnm + "','" + stradd + "')", con);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Data inserted successfylly");
            }
            else
            {
                Console.WriteLine("Error");
            }
            cmd.Dispose();
            con.Close();
        }
    }
}
