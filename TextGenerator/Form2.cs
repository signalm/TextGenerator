﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGenerator
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.BackColor = Color.Black; BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.instance.tbf1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.instance.tbf1.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.instance.BackColor = Color.White; BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cant get it to work rip");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding in new updates");  
            // Use this code For later updates Test code: openFileDialog1.Filter = ("png");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
        }
    }
}
