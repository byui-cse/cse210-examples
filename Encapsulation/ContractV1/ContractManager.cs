using System;
using System.Collections.Generic;
using System.IO;

namespace ContractV1
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
                    writer.WriteLine(c._projectName + "|" + c._budget + "|" + c._contractorName + "|" + c._isActive);
                }
            }
            finally
            {
                writer.Close();
            }
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
                    string[] parts = line.Split('|');

                    // The manager is responsible for knowing exactly 
                    // which index corresponds to which field.
                    Contract c = new Contract();
                    c._projectName = parts[0];
                    c._budget = double.Parse(parts[1]);
                    c._contractorName = parts[2];
                    c._isActive = bool.Parse(parts[3]);

                    _contracts.Add(c);
                }
            }
            finally
            {
                reader.Close();
            }
        }

        public void ShowReport()
        {
            foreach (Contract c in _contracts)
            {
                Console.WriteLine("Project: " + c._projectName);
            }
        }
    }
}
