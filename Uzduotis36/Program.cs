using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis36
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<int> pazymiai = new List<int> { 10, 7, 8, 8, 9 };
            Mokinys VardPavardenis = new Mokinys("Vardenis", "Pavardenis", 16, 10, pazymiai);
            VardPavardenis.Informacija(); 
            List<int> pazymiai1 = new List<int> { 4, 7, 6, 7, 4 };
            Mokinys VieVienauskas = new Mokinys("Vienas", "Vienauskas", 17, 11, pazymiai1);
            VieVienauskas.Informacija();
            List<int> pazymiai2 = new List<int> { 4, 7, 8, 5, 9 };
            Mokinys AntAntrauskas = new Mokinys("Antras", "Antrauskas", 14, 8, pazymiai2);
            AntAntrauskas.Informacija();
        }
    }
    
}
