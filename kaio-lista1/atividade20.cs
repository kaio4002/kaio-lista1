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
    public partial class atividade20: Form
    {
        public atividade20()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                string AA, S, ordem;

                AA = textBox1.Text;
                S = textBox2.Text;
                ordem = textBox3.Text;
               
                label5.Text = AA + "/" + S ;
                

           
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
