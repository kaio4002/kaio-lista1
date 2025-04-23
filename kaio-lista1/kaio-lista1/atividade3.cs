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
    public partial class atividade3 : Form
    {
        public atividade3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double HT, TD, PD,  SL,VH,SB;
            HT = Convert.ToDouble(qnthour.Text);
            VH = Convert.ToDouble(valorhor.Text);
            PD = Convert.ToDouble(percd.Text);

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;
            result.Text = "R$" + SL.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qnthour.Text = "";
            valorhor.Text = "";
            percd.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
