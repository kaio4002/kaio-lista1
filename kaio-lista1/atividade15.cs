﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaio_lista1
{
    public partial class atividade15: Form
    {
        public atividade15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2;

                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                label5.Text = num1.ToString();
                label7.Text = num2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label7.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
