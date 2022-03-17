using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEoutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            Console.WriteLine(salario);

            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            long idade = 1900000000000000000;
            Console.WriteLine(idade);


            short quantidadeDeProdutos = 15000;
            Console.WriteLine(quantidadeDeProdutos);

            float altura = 1.70f;
            Console.WriteLine(altura);



            Console.WriteLine("Programa finalizado, tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
