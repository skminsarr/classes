using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TreeViewFromDb
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("India");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C25MSTP\SQLEXPRESS; Initial Catalog=master; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select distinct state from india", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                int i = 0;
                foreach (DataRow drow in dt.Rows)
                {
                    treeView1.Nodes[0].Nodes.Add(drow["state"].ToString());
                    SqlCommand cmd2 = new SqlCommand("select dist from india where state='" + drow["state"].ToString() + "'", con);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    
                    foreach(DataRow drow2 in dt2.Rows)
                    {
                        treeView1.Nodes[0].Nodes[i].Nodes.Add(drow2["dist"].ToString());
                        
                    }

                    da2.Dispose();
                    cmd2.Dispose();
                    i++;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
        }
    }
}
