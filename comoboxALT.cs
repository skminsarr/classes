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
namespace comboboxALT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-3G9KFH97;Initial Catalog=master;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select name from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);

                //comboBox1.DataSource = dt;
                //comboBox1.DisplayMember = "name";
                //comboBox1.ValueMember = "id";
                comboBox1.Items.Add("select");
                comboBox1.Text = "select";
                foreach (DataRow drow in dt.Rows)
                {
                    comboBox1.Items.Add(drow["name"].ToString());

                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
