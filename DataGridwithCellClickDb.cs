using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp38
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-C25MSTP\\SQLEXPRESS; Initial Catalog=master; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select empid as 'Employee ID',name as 'Employee Name',address as 'Address',salary as 'Salary' from emp", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                Form3 dlg = new Form3(dataGridView1.SelectedRows[0].Cells["Employee ID"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["Employee Name"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString());

                dlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("select valid row", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
