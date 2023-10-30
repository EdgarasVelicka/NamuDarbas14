using System;
using System.Linq;


namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1. Temperatūra
            int[] temp = { 3, 1, -2, 2, 4, 0, -1 };
            int min = temp.Min();
            int max = temp.Max();
            double vidurkis = temp.Sum()/temp.Length;
            Console.WriteLine("Žemiausia savaitės oro teperatūra: " + min);
            Console.WriteLine("Aukščiausia savaitės oro temperatūra: " + max);
            Console.WriteLine("Savaitės oro temperatūros vidurkis: " + vidurkis);
            int skai = 0;
            foreach (int i in temp)
            {
                if (i < vidurkis)
                    skai++;
            }
            Console.WriteLine("Kiek temperatūros rodmenų yra žemiau už vidurkį: " + skai);
            int sk = 0;
            foreach (int i in temp)
            {
                if (i > vidurkis)
                    sk++;
            }
            Console.WriteLine("Kiek temperatūros rodmenų yra aukščiau už vidurkį: " + sk);
            Console.WriteLine();
            // 2. Pažymiai
            int[] paz = { 10, 8, 7, 7, 2, 4, 8, 6, 5, 10, 9, 3 };
            int ger = paz.Max();
            Console.WriteLine("Geriausias gautas pažymys: " + ger);
            int desimt = 0;
            foreach (int i in paz) 
            {
                if (i == 10)
                    desimt++;
            }
            Console.WriteLine("Aukščiausią įvertinimą gavusių skaičius: " + desimt);
            int neig = 0;
            foreach  (int i in paz)
            {
                if (i < 4)
                   neig++;
            }
            Console.WriteLine("Nepatenkinamą balą gavusių skaičius: " + neig);
            double Vidurkis = paz.Sum() / paz.Length;
            Console.WriteLine("Visų įvertinimų vidurkis: " + Vidurkis);
        }
    }
}
