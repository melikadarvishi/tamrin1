﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            z = x + y;
            textBox3.Text = z.ToString();

        }

       

        

        
    }
}
