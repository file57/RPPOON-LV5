using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShipable p1 = new Product("ulje", 3.99, 1);
            IShipable p2 = new Product("ormar", 1799.99, 57);
            IShipable p3 = new Product("televizor", 2739.99, 10);
            IShipable p4 = new Product("printer", 1199.99, 5);
            IShipable p5 = new Product("lemilica", 69.99, 0.25);

            Box box = new Box("Kutija za slanje");

            ShippingService boxForCroatia = new ShippingService();

            Console.WriteLine(box.Description() + boxForCroatia.PriceWithShipping(box) + " kn");

            box.Add(p2);
            box.Add(p3);
            box.Add(p5);
            Console.WriteLine();
            Console.WriteLine(box.Description() + "Cijena bez dostave: " + box.Price + "\nCijena sa dostavom: " + boxForCroatia.PriceWithShipping(box) + " kn");
        }
    }
}
