using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCellClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strdata = { "1" };
            string[] strdata2 = { "2" };
            string[] strdata3 = { "3" };
            string[] strdata4 = { "4" };

            dataGridView1.Rows.Add(strdata);
            dataGridView1.Rows.Add(strdata2);
            dataGridView1.Rows.Add(strdata3);
            dataGridView1.Rows.Add(strdata4);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count - 1 && e.ColumnIndex == 1)
            {
                Form2 dlg = new Form2(dataGridView1.Rows[e.RowIndex].Cells["sino"].Value.ToString());
                dlg.ShowDialog();
            }
            else
            {
            }
        }
    }
}
