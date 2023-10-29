using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int pirmSkaicius = 29;
            int antrSkaicius = 4;
            int trecSkaicius = 27;
            int suma = Sudetis(pirmSkaicius, antrSkaicius, trecSkaicius);
            Console.WriteLine($"Skaičių {pirmSkaicius}, {antrSkaicius} ir {trecSkaicius} suma yra {suma}");
            double dalmuo = Dalyba(pirmSkaicius, antrSkaicius);
            Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} dalmuo yra {dalmuo}"); 



        }
        static int Sudetis(int pirmSkaicius, int antrSkaicius, int trecSkaicius)
        {
            return pirmSkaicius + antrSkaicius + trecSkaicius;
        }
        static double Dalyba(int pirmSkaicius, int antrSkaicius)
        {
            return (double)pirmSkaicius / antrSkaicius;
        }
    }
}
