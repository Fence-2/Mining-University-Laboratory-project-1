using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Blue;
            label2.BackColor = Color.Purple;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
            label4.BackColor = Color.LightBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Black;
            label4.BackColor = Color.DarkGreen;
        }
    }
}
