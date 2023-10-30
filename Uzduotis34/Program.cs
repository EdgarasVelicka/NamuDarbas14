using System;


namespace Uzduotis34
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
            if (veiksmas == "Daugyba")
            {
                Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} sandauga: {Program.Daugyba(pirmSkaicius, antrSkaicius)}");
            }
            else if (veiksmas == "Dalyba")
            {
                Console.WriteLine($"Skaičių {pirmSkaicius} ir {antrSkaicius} dalmuo: {Program.Dalyba(pirmSkaicius, antrSkaicius)}");
            }
            else
            {
                Console.WriteLine("Tokio veiksmo nėra");
            }
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
