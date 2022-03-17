using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 Calcula a Poupança ");


            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + "° mês seu dinheiro investido vai render R$" + valorInvestido);
                contadorMes++;
            }
           






            Console.WriteLine("Projeto finalizado, aperter Enter para sair");
            Console.ReadLine();



        }
    }
}
