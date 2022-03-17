using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalcularPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 Calcula a Poupança ");


            double valorInvestido = 1000;


            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {

                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("Após " + contadorMes + "° mês, você terá de investimento R$" + valorInvestido);



            }





            Console.WriteLine("Projeto finalizado, aperter Enter para sair");
            Console.ReadLine();


        }
    }
}
