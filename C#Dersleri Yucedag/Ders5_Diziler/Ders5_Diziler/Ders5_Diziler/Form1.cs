﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Harfler = { "a", "b","c","d","e","f" };

            label1.Text = Harfler[0];
            label2.Text = Harfler[1];
            label3.Text = Harfler[2];
            label4.Text = Harfler[3];
            label5.Text = Harfler[4];
            label6.Text = Harfler[5];
        }
    }
}
