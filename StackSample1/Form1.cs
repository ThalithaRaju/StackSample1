using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackSample1
{
    public partial class Form1 : Form
    {
        Stack<string> names = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            names.Push(txtOne.Text);
            lstBox.Items.Add(txtOne.Text);
            txtOne.Text = string.Empty;
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOne.Text = lstBox.SelectedItem.ToString();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (names.Count!=0)
            {
                lstBox.Items.Remove(names.Pop());
            }
            else
            {
                MessageBox.Show("Stack is empty");
            }
        }
    }
}
