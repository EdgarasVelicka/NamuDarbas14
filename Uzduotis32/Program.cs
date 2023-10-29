using System;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine();
            PasisveikinimasSuVardu(vardas);  
        }
        static void PasisveikinimasSuVardu(string vardas)
        {
            Console.WriteLine("Labas " + vardas);
        }
    }
}
