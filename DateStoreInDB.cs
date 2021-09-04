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

namespace DateStoreInDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dat.Value;
            char[] charsep = { '-', '/', '.', ',' };
            string[] strset = dt.ToShortDateString().Split(charsep);
            string strdt = strset[2] + "-" + strset[1] + "-" + strset[0];
            MessageBox.Show(dt.ToShortDateString());

            SqlConnection con = new SqlConnection(@"Data Source= LAPTOP-3G9KFH97; Initial Catalog = master; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("insert into date1 values('" + strdt + "')", con);
            con.Open();
            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Date Submit Successfully");
            }
            con.Close();
        }

        private void employeedataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.ShowDialog();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }
    }
}
