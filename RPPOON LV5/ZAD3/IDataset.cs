using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ZAD3
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
