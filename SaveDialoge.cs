using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveDialoge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(IMAGE)|*.jpeg;*jpg;*png";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dlg.FileName);

                pictureBox1.Image = Image.FromFile(dlg.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(image)|*.jpg";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dlg.FileName);
                MessageBox.Show("Image save successfully");
            }
            else
            {
                MessageBox.Show("Try Again");
            }

        }
    }
}
