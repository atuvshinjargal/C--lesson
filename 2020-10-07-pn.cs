using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, a=10;
            for (a = 0; a < (int)numericUpDown1.Value; a++)
            {
                for (i = 2; i < a; i++)
                { //i=0,1,2,3,4,5,6,7,8,9
                    if (a % i == 0) //ene nuhtsul bielne gedeg bol huvaagdaj baina gesen ug.
                    {
                        break;
                    }
                }
                if (i == a)
                {
                    listBox1.Items.Add(i);
                }
            } 
        }
    }
}
