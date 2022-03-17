using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 criando variavéis ponto flutuante");

            double salario;
            salario = 1300.25;
            Console.WriteLine("Meu Salário é " + salario + "!");

            int idade = 10;
            idade = 10 / 2;
            Console.WriteLine("Minha idade é " + idade + "!");

            double ida;
            ida = 15 / 2;
            Console.WriteLine(ida);

          
            ida = 15.0 / 2;
            Console.WriteLine(ida);



            Console.WriteLine("Programa executado com sucesso, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
