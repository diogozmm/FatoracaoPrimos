using System;
using System.Collections.Generic;
using System.Text;

namespace FatoracaoPrimos
{
    class Primos
    {
        public static List<int> Fatorar(int numero)
        {
            var primos = new List<int>();

            for (int div = 2; div <= numero; div++)
            {
                while (numero % div == 0)
                {
                    primos.Add(div);
                    numero = numero / div;
                }
            }
            return primos;
        }

     
    }
}

