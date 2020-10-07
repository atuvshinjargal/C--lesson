using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileandfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tuvshuu" && textBox2.Text == "1234")
            {
                //ta amjiltai nevterlee
                MessageBox.Show("ta amjilttai nevterlee.");
            }
            else
            {
                MessageBox.Show("Tanii ner, nuuts ug buruu baina.");
            }
        }
    }
}
