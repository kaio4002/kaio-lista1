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
    public partial class atividade18: Form
    {
        public atividade18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double salariobruto, descontoprevidencia, salarioaposprevidencia, descontoimposto, salarioliquido;

                salariobruto = Convert.ToDouble(textBox1.Text);

                descontoprevidencia = salariobruto * 0.10;
                salarioaposprevidencia = salariobruto - descontoprevidencia;
                descontoimposto = salarioaposprevidencia * 0.05;
                salarioliquido = salarioaposprevidencia - descontoimposto;




                label7.Text = "R$" + salarioliquido.ToString();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
