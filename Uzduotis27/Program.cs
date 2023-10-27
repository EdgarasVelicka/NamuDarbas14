using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<string> zodziai = new List<string> { "stalas", "sofa", "spinta", "spintelė", "komoda" };
            string ilgZodis = zodziai.OrderByDescending(w => w.Length).First();
            Console.WriteLine($"Ilgiausias žodis:   {ilgZodis},  jis sudarytas iš: {ilgZodis.Length} raidžių");
            string trumpZodis = zodziai.OrderByDescending(w => w.Length).Last();
            Console.WriteLine($"Trumpiausias žodis:  {trumpZodis}, jis sudarytas iš: {trumpZodis.Length} raidžių");
        }
    }
}
