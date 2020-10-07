using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, s;
            label1.Text = "PN=";
            for (i = 2; i < 1000; i++)
            { //i=2, 3, 4, 5, 6, 7, 8, 9 
                s = 0;
                for (int j = 2; j < i; j++)
                {//j=2; 2,3; 2,3,4; 2,3,4,5; .....
                    if (i % j == 0)
                    {
                        s++;
                        break;
                    }
                }
                if (s == 0)
                {
                    label1.Text += i.ToString();
                    label1.Text += ";";
                }  
            }
        }
    }
}
