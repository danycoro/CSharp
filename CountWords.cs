using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// ReSharper disable StringLiteralTypo

using static System.Console;
namespace Consola
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = "Do you like green eggs and ham? " +
                          "I do not like them, Sam-I-am " +
                          "I do not like green eggs and ham.";

            ;
            foreach (KeyValuePair<string, int> result in CountWords(text))
            {

                WriteLine($"Palabra: {result.Key} \t\tFrecuencia: {result.Value} ");
            }

            ReadKey();
        }
        
        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> frequencies;
            //Ignorar Mayusculas o minusculas
            frequencies = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            //Sin ignorar Mayusculas o minusculas
            //frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                    frequencies[word]++;
                else
                    frequencies[word] = 1;
            }
            return frequencies;
        }
    }
}
         
