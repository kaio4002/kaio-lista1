using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaio_lista1
{
    public partial class atividade8 : Form
    {
        public atividade8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label3.Text =  "o valor de A agora é :" +textBox2.Text;
           label5.Text = "o valor de B agora é :" + textBox1.Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
