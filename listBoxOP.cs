using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listBoxOP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int i in listBox1.SelectedIndices)
            {
                MessageBox.Show(listBox1.Items[i].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //listBox1.Items.Remove("sun");
            listBox1.Items.RemoveAt(0);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("sun");
            listBox1.Items.Add("mon");
            listBox1.Items.Add("tue");
           
        }
    }
}
