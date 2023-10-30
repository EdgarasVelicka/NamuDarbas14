using System;


namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            pasisveikinimasSuVartotoju();  
        }
        static void pasisveikinimasSuVartotoju()
        {
            Console.Write("Įrašykite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įrašykite savo hobį: ");
            string hobis = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Sveiki jūsų vardas {vardas} ({amzius} metai), hobis yra {hobis}");
        }    
    }
}
