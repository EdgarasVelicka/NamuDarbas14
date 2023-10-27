using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1d.
            List<int> numbers = new List<int> { 77, 18, 83, 2, 56, 23, 39, 9 };
            Console.WriteLine("Mažiausias sąrašo skaičius: " + numbers.Min());
            Console.WriteLine("Didžiausias sąrašo skaičius: " + numbers.Max());
            Console.WriteLine("Saraše nurodytų reikšmių vidurkis: " + numbers.Average());
            int mazVid = 0;
            foreach (int i in numbers)
            {
                if (i < numbers.Average())
                    mazVid++;
            }
            Console.WriteLine("Kiek skaičių, saraše, yra mažesni už vidurkį: " + mazVid);
            int lygSkSuma = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    lygSkSuma += i;
                }
            }
            Console.WriteLine("Sąrašo lyginių reikšmių suma: " + lygSkSuma);
            Console.WriteLine();

            // 2 d.
            Console.WriteLine();
            List<int> pazymiai = new List<int>();
            Console.WriteLine("Suveskite pažymius (suveskite 'pabaiga', kai norite nutraukti)");
            string ivestis;
            while ((ivestis = Console.ReadLine()) != "pabaiga")
            {
                int pazymys;
                bool arPavyko = int.TryParse(ivestis, out pazymys);
                if (arPavyko)
                {
                    pazymiai.Add(pazymys);
                }
                else 
                { 
                    Console.WriteLine("Įveskite: 'pabaiga'");
                }
            }
            Console.WriteLine("Didžiausias pažymys: " + pazymiai.Max());
            Console.WriteLine("Mažiausias pažymys: " + pazymiai.Min());
            Console.WriteLine("Pažymių vidurkis: " + pazymiai.Average());
        }   
    }
}
