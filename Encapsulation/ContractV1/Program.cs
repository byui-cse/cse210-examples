using System;
using System.Collections.Generic;
using System.IO;

namespace ContractV1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractManager manager = new ContractManager();

            Contract c1 = new Contract();
            c1._projectName = "Old Bridge";
            c1._budget = 1000.0;
            c1._contractorName = "Cheap Builders";
            c1._isActive = true;

            manager.AddContract(c1);
            manager.SaveToDisk();
            manager.LoadFromDisk();
            manager.ShowReport();
            
            Console.WriteLine("Done.");
        }
    }
}
