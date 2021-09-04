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
using System.IO;
using System.Drawing.Imaging;

namespace ImageDbView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-3G9KFH97; Initial Catalog=master; Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select img from tab1 where sino=1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);

                foreach (DataRow drow in dt.Rows)
                {
                    byte[] picarray = (byte[])drow["img"];
                    MemoryStream ms = new MemoryStream(picarray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
