using System;
using FatoracaoPrimos;

namespace FatoracaoPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para ser fatorado: ");
            int value = int.Parse(Console.ReadLine());

            foreach(var i in Primos.Fatorar(value))
            {
                Console.WriteLine(i);
            }
           
        }
    }

   
}

