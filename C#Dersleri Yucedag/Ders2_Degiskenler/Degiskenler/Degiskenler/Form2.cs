﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Int : Form
    {
        public int IlkKenar = 10;
        public int IkinciKenar = 20;
        public int KareKenar = 10;
        public Int()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Cevre " + ((IlkKenar + IkinciKenar) * 2);
            textBox7.Text = ((KareKenar + KareKenar)*2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
