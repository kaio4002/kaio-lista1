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
    public partial class atividade6 : Form
    {
        public atividade6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double volume, altura, raio, total;
            raio = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);
            volume = 3.14159;
            total = volume * raio *4 * altura;
            
                
            result.Text = total.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            result.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
