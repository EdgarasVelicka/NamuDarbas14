using System;

namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Pasirinkite, kiek duomenų įvesti: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            int sumaLyg = 0;
            int sumaNelyg = 0;
            Console.WriteLine();
            int[] atstumai = new int[kiekis];
            for (int i = 0; i < atstumai.Length; i++) 
            {
                Console.WriteLine("Įveskite atstumą: ");
                atstumai[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int i in atstumai)
            {
                if(i % 2 == 0)
                {
                    sumaLyg += i;
                }
            }
            Console.WriteLine("Lyginių atstumų suma: " + sumaLyg);
            Console.WriteLine();
            foreach (int i in atstumai)
            {
                if (i % 2 != 0)
                {
                    sumaNelyg += i;
                }
            }
            Console.WriteLine("Nelyginių atstumų suma: " + sumaNelyg);
        }
    }
}
