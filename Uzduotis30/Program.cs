using System;


namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Aritmetiniai veiksmai su dviem skaičiais");
            Console.WriteLine();
            Console.Write("Įveskite pirmą skaičių: ");
            int pirmSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int antrSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Šių skaičių suma yra: {Program.Sudetis(pirmSkaicius, antrSkaicius)}");
            Console.WriteLine($"Šių skaičių skirtumas yra: {Program.Atimtis(pirmSkaicius, antrSkaicius)}");
            Console.WriteLine($"Šių skaičių sandauga yra: {Program.Daugyba(pirmSkaicius, antrSkaicius)}");
            Console.WriteLine($"Šių skaičių dalmuo yra: {Program.Dalyba(pirmSkaicius, antrSkaicius)}");
        }
        static int Sudetis(int pirmSkaicius, int antrSkaicius)
        {
            return pirmSkaicius + antrSkaicius;
        }
        static int Atimtis(int pirmSkaicius, int antrSkaicius)
        {
            return pirmSkaicius - antrSkaicius;
        }
        static int Daugyba(int pirmSkaicius, int antrSkaicius)
        {
            return pirmSkaicius * antrSkaicius;
        }
        static double Dalyba(int pirmSkaicius, int antrSkaicius)
        {
            return (double)pirmSkaicius / antrSkaicius;
        }
    }
}
