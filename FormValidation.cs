using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("load");
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                MessageBox.Show("valid data");
            }
        }

       

       

        private bool isvalid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Enter  name");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("enter age");
                textBox2.Focus();
                return false;
            }
            else
            {
                double output;

                if (double.TryParse(textBox2.Text, out output) == true)
                {
                    //MessageBox.Show("valid data");
                }
                else
                {
                    MessageBox.Show("Kindly enter numeric data");
                    textBox2.Focus();
                }

            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
