using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShipable p1 = new Product("tava", 250, 1);
            IShipable p2 = new Product("tabure", 200, 5);
            IShipable p3 = new Product("stol", 500, 50);

            Box kutija = new Box("BIG BOX");

            kutija.Add(p1);
            kutija.Add(p2);
            kutija.Add(p3);

            Console.WriteLine(kutija.Price + "\n" + kutija.Weight + "\n" + kutija.Description());
            
        }
    }
}
