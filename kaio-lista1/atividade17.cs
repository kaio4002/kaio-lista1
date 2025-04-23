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
    public partial class atividade17: Form
    {
        public atividade17()
        {
            InitializeComponent();
        }

        private void atividade17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double value1, value2, total1, total2;


                value1 = Convert.ToDouble(textBox1.Text);
                value2 = Convert.ToDouble(textBox2.Text);

                total1 = value1 / value2;
                total2 = value1 % value2;

                if (total2 == 0)
                {
                    label5.Text = "não há sobras";
                }
                else
                {
                    label5.Text = total2.ToString();
                }
                label7.Text = total1.ToString();
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
            label7.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
