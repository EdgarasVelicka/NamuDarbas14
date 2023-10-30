using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Oras();
        }
            private static void Oras()
            {
                Console.WriteLine("Koks šiandien oras? ");
                string oroPrognoze = Console.ReadLine ();
                Console.WriteLine("Šiandien oras yra: " + oroPrognoze);
            }
    }
}
