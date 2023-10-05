using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pont pont1 = new Pont();
            Pont pont2 = new Pont(1, 2);
            Pont pont3 = new Pont(3);

            Console.WriteLine($"p1 {pont1}, Távolsag {pont1.Tavolsag()}");
            Console.WriteLine($"p2 {pont2}, Távolsag {pont2.Tavolsag()}");
            Console.WriteLine($"p3 {pont3}, Távolsag {pont3.Tavolsag()}");

            Pont[] pontok = new Pont[10];
            //listánál lemaradtam

        }
    }
}
