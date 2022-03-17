using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 Condicinonais");


            int idade = 12;
            int quantidadePessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("João tem " + idade + " anos e pode entrar!");
            }
            if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João, não possue mais de 18, mas está acompanhado. pode entrar!");
                }
            else 
            {
               
                Console.WriteLine("João tem menos de 18 anos e não pode entrar");
            }








            Console.WriteLine("Projeto finalizado, aperter Enter para sair");
            Console.ReadLine();
        }
    }
}
