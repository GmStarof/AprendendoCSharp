using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 Escopo ");


            int idade = 22;
            int quantidadePessoas = 2;

            bool acompanhantes = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhantes == true)
            {
                Console.WriteLine("João tem " + idade + " anos");
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
