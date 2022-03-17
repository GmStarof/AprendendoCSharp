using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5, Caracteres e textos!");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura curso de tecnologia " + 2020;
            string cursosProgramaçao =
@" - .NET
 - Java
 - Java Script";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramaçao);


            Console.WriteLine("Projeto finalizado, aperte Enter para sair...");
            Console.ReadLine();




        }
    }
}
