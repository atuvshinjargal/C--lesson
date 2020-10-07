using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n; // n gesen huvisagchiig zarlaj baina.
            string s = ""; //s stringiig hooson bolgoj baina.
            n = (int)numericUpDown1.Value; //davtah toogoo numericUpDown1 -s avch baina.
            int i = 1; // i-d neg gesen utga ugch baina.
            while (i <= n) //() haaltan dotorh nuhtsul bielsen bol doorh uildliig guicetgene.
            {
                s =s+"I"; //s string deer "I" -g zalgaj baina.
                listBox1.Items.Add(s); //s stringiig listBox -d nemj baina.
                i++; // i-g negeer nemgduulj baina.
            }
            s = ""; //s stringiig hooson bolgoj baina.
            for (i = 1; i <= n; i++) //i=1 gedeg bol i-g 1 s ehluulne. i<=n gedeg bol ene nuhtsul bielj baih ued davtana.
            {
                s = s + "I"; //s string deer "I" -g zalgaj baina.
                listBox1.Items.Add(s); //s stringiig listBox -d nemj baina.
            }
            // i++ gedeg bol i -g negeer nemegduulj baina.
        }
    }
}
