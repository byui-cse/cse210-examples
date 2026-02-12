using System;
using System.Collections.Generic;
using System.IO;

namespace ContractV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractManager manager = new ContractManager();

            // Create objects via constructor
            Contract c1 = new Contract("Bridge Alpha", 50000.0, "Builders Ltd", true);
            manager.AddContract(c1);

            manager.SaveToDisk();
            manager.LoadFromDisk();
            manager.DisplayAll();

            Console.WriteLine("Done.");
        }
    }
}
