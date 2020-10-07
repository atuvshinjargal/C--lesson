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
            //factorial
            //5-n fac=1*2*3*4*5=120
            int f = 1;
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                f = f * i; // 1*1*2*3*4*5=>f
            }
            listBox1.Items.Add(f);
        }
    }
}
