using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSub_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);
            double sub = value1 - value2;
            lblResult.Text = sub.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e) {
            
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);
            double mult = value1 * value2;
            lblResult.Text = mult.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);
            double div = value1 / value2;
            lblResult.Text = div.ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            double value1 = System.Convert.ToDouble(txbValor1.Text);
            double value2 = System.Convert.ToDouble(txbValor2.Text);

            double soma = value1 + value2;


            lblResult.Text = soma.ToString();
        }

     

    }
}
