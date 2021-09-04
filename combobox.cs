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

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("select");

            comboBox1.Items.Add("year");
            comboBox1.Items.Add("month");

            comboBox1.Text = "select";

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-3G9KFH97;Initial Catalog=master;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);

                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "name";
                //comboBox3.ValueMember = "id";


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.Text=="year")
            {
                comboBox2.Items.Add("2019");
                comboBox2.Items.Add("2018");
                comboBox2.Items.Add("2017");
            }
            else if(comboBox1.Text=="month")
            {
                comboBox2.Items.Add("jan");
                comboBox2.Items.Add("feb");
                comboBox2.Items.Add("mar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(0);
        }
    }
}
