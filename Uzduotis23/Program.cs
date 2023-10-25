using System;
using System.Linq;


namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keliones
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double degal = 5.5; // litrai 100-ui km
            double[] km = { 80, 42.8, 74.7, 14.8, 17, 23, 9 };
            double min = km.Min();
            Console.WriteLine($"Trumpiausias nuvažiuotas atstumas: {min} km");
            double max = km.Max();
            Console.WriteLine($"Ilgiausias nuvažiuotas atstumas: {max} km");
            double suma = 0;
            for ( int i = 0; i < km.Length; i++ )
            {
                suma += km[i];
            }
            Console.WriteLine($"Kuras, sunaudotas, nuvažiavus visus atstumas: {5.5*100/suma} litrai");


        }
    }
}
