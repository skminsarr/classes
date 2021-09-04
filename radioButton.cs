using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show("science");
            }
           else if (radioButton2.Checked)
            {
                MessageBox.Show("arts");
            }
           else
            {
                MessageBox.Show("commerce");
            }

            if (radioButton4.Checked)
            {
                MessageBox.Show("ENGLISH");
            }
            else if (radioButton5.Checked)
            {
                MessageBox.Show("HINDI");
            }
            else
            {
                MessageBox.Show("BENGALI");
            }
        }
    }
}
