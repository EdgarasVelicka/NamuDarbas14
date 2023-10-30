using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis36
{
    internal class Mokinys
    {
        string vardas;
        string pavarde;
        int amzius;
        int klase;
        List<int> pazymiai;
        public Mokinys(string vardas, string pavarde, int amzius, int klase, List<int>pazymiai)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiai = pazymiai;
        }
        public void Informacija()
        {
            Console.WriteLine($"Mokinio vardas, pavardė: {vardas}, {pavarde}, {amzius} metai, {klase} klasė, pažymiai: ");
            foreach (int i in this.pazymiai)
            {
                Console.WriteLine("Pažymiai : " + i);
            }
            
        }
    }
}
