using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis21_Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Masyvai
            //Pazymiai
            int[] studentuPazymiai = { 8, 8, 3, 9, 5, 10, 9, 8, 9, 6, 6, 3, 4, 4 };
            //Auto markes
            string[] automobiliuMarkes = new string[6];
            automobiliuMarkes[0] = "Audi";
            automobiliuMarkes[1] = "Bmv";
            automobiliuMarkes[2] = "Dacia";
            automobiliuMarkes[3] = "Ford";
            automobiliuMarkes[4] = "Skoda";
            automobiliuMarkes[5] = " Volkswagen";

            Console.Write("Studentų pažymių kiekis: ");
            Console.WriteLine(studentuPazymiai.Length);
            Console.WriteLine();
            Console.Write("Pirma automobilio markė: "); Console.WriteLine(automobiliuMarkes.First());
            Console.Write("Paskutinė automobilio markė: "); Console.WriteLine(automobiliuMarkes.Last());



        }
    }
}
