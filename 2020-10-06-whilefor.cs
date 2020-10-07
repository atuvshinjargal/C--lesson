using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            while (i < numericUpDown1.Value)
            {
                s += "I";
                listBox1.Items.Add(s);
                i++;
            }
            s = "";
            for (i = 0; i < numericUpDown1.Value; i++)
            {
                s += "I";
                listBox1.Items.Add(s);
            }
        }
    }
}
