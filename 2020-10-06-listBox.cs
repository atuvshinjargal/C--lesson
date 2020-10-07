using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            int i = 0;
            while (i < textBox1.Text.Length)
            {
                listBox1.Items.Add(textBox1.Text[i]);
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            while (i < numericUpDown1.Value)
            {
                s += "I";
                listBox1.Items.Add(s);
                i++;
            }
        }
    }
}
