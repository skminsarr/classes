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

namespace ImageDbInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("D:\\IMG-20181028-WA0003.jpg");
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(avishek)|*.jpeg;*jpg;*png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dlg.FileName);
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-3G9KFH97; Initial Catalog=master; Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into tab1 values(@pic)", con);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] picarray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(picarray, 0, picarray.Length);
            cmd.Parameters.AddWithValue("@pic", picarray);
            //cmd.Parameters.AddWithValue("@name", TextBox1.text);


            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data saved successfully");
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
 
