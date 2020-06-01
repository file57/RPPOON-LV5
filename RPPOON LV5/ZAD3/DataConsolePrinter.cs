using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class DataConsolePrinter
    {
        VirtualProxyDataset virtualproxydataset;
        ProtectionProxyDataset protectionproxydataset;
        public DataConsolePrinter(VirtualProxyDataset virtualproxydataset, ProtectionProxyDataset protectionproxydataset)
        {
            this.virtualproxydataset = virtualproxydataset;
            this.protectionproxydataset = protectionproxydataset;
        }

        public void GetData(IDataset dataset)
        {
            foreach(List<string> list in dataset.GetData())
            {
                foreach(string data in list)
                {
                    Console.Write("{0} ", data);
                }
                Console.WriteLine();
            }
        }
    }
}
