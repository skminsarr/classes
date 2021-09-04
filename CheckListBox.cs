using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("sun");
            checkedListBox1.Items.Add("mon");
            checkedListBox1.Items.Add("tue");
            checkedListBox1.Items.Add("wed");
            checkedListBox1.Items.Add("thus");
            checkedListBox1.Items.Add("fri");
            checkedListBox1.Items.Add("sat");
            checkedListBox1.SetItemChecked(1,true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(int i in checkedListBox1.SelectedIndices)
            {
                MessageBox.Show(checkedListBox1.Items[i].ToString());
            }
        }
    }
}
