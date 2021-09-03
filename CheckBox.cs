using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.ForeColor.ToString());
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("u have selected both ");
            }
            else if (checkBox1.Checked == true)
            {
                MessageBox.Show("u have selected tea");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("u have selected coffee");
            }
            else
            {
                MessageBox.Show("none");
            }

            if (chkcold.Checked)
            {
                MessageBox.Show("cold drinks");
            }
        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            MessageBox.Show("Enter");
        }

        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            MessageBox.Show("left");
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox2.Checked.ToString());
        }

        private void checkBox2_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("hovering");
        }
    }
}
