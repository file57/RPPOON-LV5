using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class ShippingService
    {
        private double pricePerWeight;
        public ShippingService(double pricePerWeight = 1.2)
        {
            this.pricePerWeight = pricePerWeight;
        }

        public double PriceWithShipping(Box box)
        {
            double shippigPerWeight = pricePerWeight * box.Weight;

            return shippigPerWeight + box.Price;
        }
    }
}
