using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadTreeViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radTreeView1.SelectedNodeChanged += radTreeView1_SelectedNodeChanged;
            radTreeView1.MultiSelect = true;
            RadTreeNode node1 = new RadTreeNode("a");
            node1.Nodes.Add(new RadTreeNode{ Text = "a1" });
            node1.Nodes.Add(new RadTreeNode{ Text = "a2" });
            RadTreeNode node2 = new RadTreeNode("b");
            node2.Nodes.Add(new RadTreeNode { Text = "b1" });
            node2.Nodes.Add(new RadTreeNode { Text = "b2" });
            RadTreeNode node3 = new RadTreeNode("c");
            RadTreeNode node4 = new RadTreeNode("d");
            radTreeView1.Nodes.Add(node1);
            radTreeView1.Nodes.Add(node2);
            radTreeView1.Nodes.Add(node3);
            radTreeView1.Nodes.Add(node4);
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            for (int w = 0; w < radTreeView1.SelectedNode.Nodes.Count; w++)
            {
                radTreeView1.SelectedNode.Nodes[w].Selected = true;
            }
        }
    }
}
