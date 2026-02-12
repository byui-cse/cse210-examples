using System;
using System.Collections.Generic;
using System.IO;

namespace ContractV2
{
    public class ContractManager
    {
        private List<Contract> _contracts = new List<Contract>();
        private string _fileName = "contracts.txt";

        public void AddContract(Contract c)
        {
            _contracts.Add(c);
        }

        public void SaveToDisk()
        {
            StreamWriter writer = new StreamWriter(_fileName);
            try
            {
                foreach (Contract c in _contracts)
                {
                    // The Manager doesn't access fields; it calls a behavior.
                    writer.WriteLine(c.Serialize());
                }
            }
            finally
            {
                writer.Close();
            }
            Console.WriteLine("Saved successfully.");
        }

        public void LoadFromDisk()
        {
            if (!File.Exists(_fileName)) return;

            _contracts.Clear();
            StreamReader reader = new StreamReader(_fileName);
            try
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Contract c = new Contract();
                    // The Manager tells the contract to "fill itself up"
                    c.Deserialize(line);
                    _contracts.Add(c);
                }
            }
            finally
            {
                reader.Close();
            }
            Console.WriteLine("Loaded successfully.");
        }

        public void DisplayAll()
        {
            foreach (Contract c in _contracts)
            {
                Console.WriteLine("Project: " + c.GetProjectName() + ")");
            }
        }
    }
}
