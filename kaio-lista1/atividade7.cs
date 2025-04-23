using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaio_lista1
{
    public partial class atividade7 : Form
    {
        public atividade7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double temp, velo, dis, LS;
                temp = Convert.ToDouble(boxtemp.Text);
                velo = Convert.ToDouble(velobox.Text);
                dis = temp * velo;
                LS = dis / 12;
                LS = Math.Round(LS, 2);
                dis = Math.Round(dis, 2);
                temp = Math.Round(temp, 2);
                gastoresult.Text = LS + " litros gastos".ToString();
                disresult.Text = dis + " KM percorridos".ToString();
                veloresult.Text = velo + " é a velocidade média".ToString();
                tempresult.Text = temp + " é o tempo gasto".ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempresult.Text = "";
            veloresult.Text = "";
            disresult.Text = "";
            velobox.Text = "";
            boxtemp.Text = "";
            gastoresult.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
