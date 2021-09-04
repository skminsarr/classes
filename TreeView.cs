using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Computer languages");
            treeView1.Nodes[0].Nodes.Add("C");
            treeView1.Nodes[0].Nodes.Add("java");
            treeView1.Nodes[0].Nodes.Add(".net");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Old C");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("new C");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("java beans");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("blue java");

            treeView1.Nodes[0].Nodes[2].Nodes.Add("vb.net");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("asp.net");
            //treeView1.ExpandAll();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.FullPath);
            MessageBox.Show(treeView1.SelectedNode.Text);
        }
    }
}
