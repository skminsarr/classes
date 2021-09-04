using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GridViewWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-3G9KFH97;Initial Catalog=master;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            int n = 0;
            try
            {
                con.Open();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    string sql = "insert into student values('" + dataGridView1.Rows[i].Cells["column1"].Value.ToString() + "','" + dataGridView1.Rows[i].Cells["column2"].Value.ToString() + "','" + dataGridView1.Rows[i].Cells["column3"].Value.ToString() + "')";
                    //da.InsertCommand = new SqlCommand(sql, con);
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    //n += da.InsertCommand.ExecuteNonQuery();
                    n += cmd.ExecuteNonQuery();

                }

                MessageBox.Show(n.ToString() + " rows inserted");
                dataGridView1.Rows.Clear();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strdt = { textBox1.Text, textBox2.Text, textBox3.Text };
            dataGridView1.Rows.Add(strdt);
        }
    }
}
