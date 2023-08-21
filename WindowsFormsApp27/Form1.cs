using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int i = 0, j = 1, k = 1;

            while (k <= n)
            {
                int temp;
                temp = i;
                i = j;
                j = temp + i;
                k += 1;
                listBox1.Items.Add(j);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8)
                e.Handled = true;
        }
    }
}
