using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Įveskite pirmą skaičių: ");
            int pirmSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int antrSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kokį veiksmą norite atlikti? ");
            string veiksmas = Console.ReadLine();
            Console.WriteLine();
            
            switch (veiksmas)
            {
                case "Sudetis":
                    Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} suma: {Sudetis(pirmSkaicius, antrSkaicius)}"); 
                    break;
                case "Atimtis":
                    Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} skirtumas: {Atimtis(pirmSkaicius, antrSkaicius)}");
                    break;
                case "Laipsnis":
                    Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} suma pakelta 4 laipsniu: {Laipsnis(pirmSkaicius, antrSkaicius)}");
                    break;
                case "KvadratineSaknis":
                    Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} sumos kvadratinė šaknis: {KvadratineSaknis(pirmSkaicius, antrSkaicius)}");
                    break;
                default:
                    Console.WriteLine("Toks veiksmas negalimas");
                    break;
            }
        }
        static int Sudetis(int pirmSkaicius, int antrSkaicius)
        {
            return pirmSkaicius + antrSkaicius;
        }
        static int Atimtis(int pirmSkaicius, int antrSkaicius)
        {
            return pirmSkaicius - antrSkaicius;
        }
        static double Laipsnis(double pirmSkaicius, double antrSkaicius)
        {
            return Math.Pow((pirmSkaicius + antrSkaicius), 4);
        }
        static double KvadratineSaknis(double pirmSkaicius, double antrSkaicius)
        {
            return Math.Pow((pirmSkaicius + antrSkaicius), 0.5);
        }
    }
}
