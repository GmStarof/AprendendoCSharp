using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6, Atribuições de Variaveis");

            int idade = 20;
            int idadeGustavo = idade;

            idade = 30;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);


            Console.WriteLine("Projeto finalizado, aperte Enter para sair.");
            Console.ReadLine();




        }
    }
}
