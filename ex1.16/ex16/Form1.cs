﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "4";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
