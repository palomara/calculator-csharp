using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Calculo
    {
        public static double AvaliaExpressao(char[] expr)
        {
            return adiciona(expr, 0);
        }

        private static double adiciona(char[] expr, int index)
        {
            double x = fatores(expr, ref index);
            while (true)
            {
                char op = expr[index]; //op - operador
                if (op != '+' && op != '-')
                    return x;
                index++;
                double y = fatores(expr, ref index);
                if (op == '+')
                    x += y;
                else
                    x -= y;
            }
        }

        private static double fatores(char[] expr, ref int index)
        {   //analisar os fatores
            double x = GetDouble(expr, ref index);
            while (true) 
            {
                char op = expr[index]; //op - operador
                if (op != '/' && op != '*')
                    return x;
                index++;
                double y = GetDouble(expr, ref index);
                if (op == '/')
                    x /= y;
                else
                    x *= y;
            }
        }
        
        
        //ref : parâmetro transmitido por referência
        private static double GetDouble(char[] expr, ref int index) //retornará da String um double
        {
            string dbl = "";
            while (((int)expr[index] >= 48 && (int)expr[index] <= 57) || expr[index] == 46) //enquanto char for dígito ou ponto converte para string
            {   //em ASCII 48 é 0; 57 é 9 e 46 é ponto
               
                dbl = dbl + expr[index].ToString();
                index++;
                if (index == expr.Length) //isso é para evitar que o índice ultrapasse os limites da matriz
                {
                    index--;
                    break;
                }
            }

            return double.Parse(dbl); //converte valor string em double
        }
    }
}
