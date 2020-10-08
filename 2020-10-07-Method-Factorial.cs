using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int fact(int i, int n) // 1, 120
        {
            if (i > 1) //2>1
            {
                i--; //2-1=1
                return fact(i,n * i); //1 , 120*1=120
            }
            else
            {
                return n;
            }
            
        } //5*4*3*2
        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            int f = this.fact(n, n); //5, 5
            label1.Text = f.ToString();
        }
    }
}
