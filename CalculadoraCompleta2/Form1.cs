using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCompleta2
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }
        
        private void button11_Click_1(object sender, EventArgs e)
        {  
            textBoxResultado.Text += "1";
        }
        private void button12_Click(object sender, EventArgs e)
        { textBoxResultado.Text += "2";

        }
        private void button13_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "3";
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "4";
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "5";
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "6";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "7";
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "8";
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {textBoxResultado.Text += "9";
            
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                label1.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a adição");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SUB";
                label1.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "MULT";
                label1.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação");
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "DIVI";
                label1.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVI")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "EXPO")
            {
                textBoxResultado.Text = Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)).ToString();
            }
            else if (operacao == "RESTO")
            {
                textBoxResultado.Text = Convert.ToString(Convert.ToDouble(valor1 % valor2));
            }
            else // (operacao == "PORCENT") não é necessário escrever na frente do else
            {
                textBoxResultado.Text = Convert.ToString((valor1 / 100) * valor2);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            label1.Text = " ";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = " ";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "PORCENT";
                label1.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o calculo");
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "EXPO";
                label1.Text = "X²";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a exponeciação");
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "RESTO";
                label1.Text = "Resto";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o resto da divisão");
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = Math.Sqrt(Convert.ToDouble(valor1)).ToString();
                operacao = "RAIZ";
                label1.Text = "√";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Raiz quadrada");
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }
    }
}
