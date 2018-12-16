using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    static class Program
    {
        static void Main(string[] args)
        {
            NumerosPar(100);
            Console.ReadKey();

        }

        public static ArrayList NumerosPar(int hastaQueNúmero)
        {
            ArrayList numeros = new ArrayList();
            for (int i = 1; i < hastaQueNúmero; i++)
            {
                if (i % 2 != 0)
                    continue;
                numeros.Add(i);
            }
            return numeros;
        }
    }
}
