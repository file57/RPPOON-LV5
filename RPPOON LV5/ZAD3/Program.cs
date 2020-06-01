using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = User.GenerateUser("korisnik1");
            User user2 = User.GenerateUser("korisnik2");
            User user3 = User.GenerateUser("korisnik3");         

            ProtectionProxyDataset ppd = new ProtectionProxyDataset(user2);
            VirtualProxyDataset vpd = new VirtualProxyDataset(@"E:\Projects\GitHub\RPPOON-LV5\RPPOON LV5\ZAD3\file.csv");

            DataConsolePrinter printer = new DataConsolePrinter(vpd, ppd);

            printer.GetData(vpd);

            Console.WriteLine("\n");
            if(ppd.GetData() == null)
            {
                Console.WriteLine("Nemate pravo pristupa podacima\n");
            }
            else
            {
                printer.GetData(ppd);
            }
            

        }
    }
}
