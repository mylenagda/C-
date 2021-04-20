using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Calculadora : Form
    {
        double valor1, valor2;
        string operacao;

        public Calculadora()
        {
            InitializeComponent();
        }

        Classes.clsoma obj1 = new Classes.clsoma();
        Classes.cldivisao obj2 = new Classes.cldivisao();
        Classes.clmultiplicacao obj3 = new Classes.clmultiplicacao();
        Classes.clsubtracao obj4 = new Classes.clsubtracao();

        private void n1_Click(object sender, EventArgs e)
        {
            Result.Text += "1";
        }
        private void n0_Click(object sender, EventArgs e)
        {
            Result.Text += "0";
        }
        private void virgula_Click(object sender, EventArgs e)
        {
            Result.Text += ",";
        }
        private void n2_Click(object sender, EventArgs e)
        {
            Result.Text += "2";
        }
        private void n3_Click(object sender, EventArgs e)
        {
            Result.Text += "3";
        }
        private void n4_Click(object sender, EventArgs e)
        {
            Result.Text += "4";
        }
        private void n5_Click(object sender, EventArgs e)
        {
            Result.Text += "5";
        }
        private void n6_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
        }
        private void n7_Click(object sender, EventArgs e)
        {
            Result.Text += "7";
        }
        private void n8_Click(object sender, EventArgs e)
        {
            Result.Text += "8";
        }
        private void n9_Click(object sender, EventArgs e)
        {
            Result.Text += "9";
        }
        private void multiplicacao_Click(object sender, EventArgs e)
        {
            operacao = "x";
            valor1 = double.Parse(Result.Text);
            Result.Clear();
        }
        private void divisao_Click(object sender, EventArgs e)
        {
            operacao = "/";
            valor1 = double.Parse(Result.Text);
            Result.Clear();
        }
        private void subtracao_Click(object sender, EventArgs e)
        {
            operacao = "-";
            valor1 = double.Parse(Result.Text);
            Result.Clear();
        }
        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(Result.Text);
            double Som;
            double Sub;
            double Div;
            double Mult;
            {
                switch (operacao)
                {
                    case "+":
                    Som = obj1.soma((valor1), (valor2));
                    Result.Text = Som.ToString();
                    break;

                    case "/":
                    Div = obj2.divisao((valor1), (valor2));
                    Result.Text = Div.ToString();
                    break;

                    case "x":
                    Mult = obj3.multiplicacao((valor1), (valor2));
                    Result.Text = Mult.ToString();
                    break;

                    case "-":
                    Sub = obj4.subtracao((valor1), (valor2));
                    Result.Text = Sub.ToString();
                    break;
                }
            }
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            Result.Clear();
        }
        private void soma_Click(object sender, EventArgs e)
        {
            operacao = "+";
            valor1 = double.Parse(Result.Text);
            Result.Clear();
        }
    }
}
