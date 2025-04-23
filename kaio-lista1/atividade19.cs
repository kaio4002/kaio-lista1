using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaio_lista1
{
    public partial class atividade19: Form
    {
        public atividade19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dia, mes, ano;
                dia =  Convert.ToInt32(textBox1.Text);
                mes = Convert.ToInt32(textBox2.Text);
                ano = Convert.ToInt32(textBox3.Text);
                

                label7.Text = ano.ToString() + "/" + mes.ToString() + "/" + dia.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


















        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label7.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

