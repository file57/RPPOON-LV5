using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }
}
