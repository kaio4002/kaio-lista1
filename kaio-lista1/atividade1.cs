using System;
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












    
    public partial class atividade1 : Form
    {
        public atividade1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double area, raio, pi, total;
                pi = 3.14;
                raio = Convert.ToDouble(textBox2.Text);
                area = pi * raio * raio;
                total = area;
                result.Text = total.ToString();
                result.Text = total + "centimetros".ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            result.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void atividade1_Load(object sender, EventArgs e)
        {

        }
    }
    }


