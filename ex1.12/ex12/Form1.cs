﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
        }
    }
}
