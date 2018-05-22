using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        double[] number = new double[5];
        string[] op = new string[4]; //operador

        public Calculadora()
        {
            InitializeComponent();
        }
        //primeira fileira
        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "/";
        }
        //segunda fileira
        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
           /* if (operation == "-" || operation == "+" || operation == "/")
            {
                operation = "*";
            }
            else
            {
                button = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operation = "*";
            } */
            txtVisor.Text = txtVisor.Text + "*";
        }
        //terceira fileira
        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            /*if (operation == "*" || operation == "+" || operation == "/")
            {
                operation = "-";
            }
            else
            {
                button = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operation = "-";
            }*/
            txtVisor.Text = txtVisor.Text + "-";
        }
        //quarta fileira
        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            /*if (operation == "+")
            {
                button += double.Parse(txtVisor.Text);
                txtVisor.Text = bottom.ToString();
            }
            else if (operation == "-")
             * 
            {
                button -= double.Parse(txtVisor.Text);
                txtVisor.Text = bottom.ToString();
            }
            else if (operation == "*")
            {
                button *= double.Parse(txtVisor.Text);
                txtVisor.Text = bottom.ToString();
            }
            else if (operation == "/")
            {
                if (double.Parse(txtVisor.Text) != 0)
                {
                    button /= double.Parse(txtVisor.Text);
                    txtVisor.Text = bottom.ToString();
                }
                else
                {
                    txtVisor.Text = "Dividindo por zero";
                }
            }*/

            //char[] x; 
            //for (int i = 0; i < txtVisor.TextLength; i++)
            //{
            //    x = txtVisor.Text.ToCharArray();
            //    if (x[i].ToString() != "+")
            //    {
            //    }
            //    else
            //    {

            //    }
            //}

            txtVisor.Text = Calculo.AvaliaExpressao(txtVisor.Text.ToCharArray()).ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
           /*double value1 = System.Convert.ToDouble(txtVisor.Text);
           double value2 = System.Convert.ToDouble(txtVisor.Text);
           double soma = value1 + value2;
           txtVisor.Text = soma.ToString(); */
           //txtVisor.Text = txtVisor.Text + "+";
            /* if (operation == "*" || operation == "-" || operation == "/")
             {
                 operation = "+";
             }
             else
             {
                button += double.Parse(txtVisor.Text);
                 txtVisor.Text = "";
                 operation = "+";
             } */

            txtVisor.Text = txtVisor.Text + "+";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        

       
    }
}
