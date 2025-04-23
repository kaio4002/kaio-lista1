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
    public partial class atividade9cs : Form
    {
        public atividade9cs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valueA, valueB, valueC, valueD;
                double somaAB, somaAC, somaAD, somaBC, somaBD, somaCD;
                double multAB, multAC, multAD, multBC, multBD, multCD;
                //peagr valores
                valueA = Convert.ToDouble(textBox1.Text);
                valueB = Convert.ToDouble(textBox2.Text);
                valueC = Convert.ToDouble(textBox3.Text);
                valueD = Convert.ToDouble(textBox4.Text);
                //somas

                double calcsoma(double value1, double value2)
                {
                    double resultado;
                    resultado = value1 + value2;

                    return resultado;
                }
                double calcmult(double value1, double value2)
                {
                    double result;
                    result = value1 * value2;

                    return result;
                }
                somaAB = calcsoma(valueA, valueB);
                somaAC = calcsoma(valueA, valueC);
                somaAD = calcsoma(valueA, valueD);
                somaBC = calcsoma(valueB, valueC);
                somaBD = calcsoma(valueB, valueD);
                somaCD = calcsoma(valueC, valueD);


                //mults
                multAB = calcmult(valueA, valueB);
                multAC = calcmult(valueA, valueC);
                multAD = calcmult(valueA, valueC);
                multBC = calcmult(valueB, valueC);
                multBD = calcmult(valueB, valueD);
                multCD = calcmult(valueC, valueD);


                //imprimir soma
                label7.Text = somaAB.ToString();
                label8.Text = somaAC.ToString();
                label8.Text = somaAD.ToString();
                label9.Text = somaBC.ToString();
                label10.Text = somaBD.ToString();
                label11.Text = somaBC.ToString();
                label12.Text = somaCD.ToString();

                //imprimir mults

                label18.Text = multAB.ToString();
                label17.Text = multAC.ToString();
                label16.Text = multAD.ToString();
                label15.Text = multBC.ToString();
                label14.Text = multBD.ToString();
                label13.Text = multCD.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {

            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
