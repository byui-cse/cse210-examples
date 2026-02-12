using System;
using System.Collections.Generic;
using System.IO;

namespace ContractV2
{
    public class Contract
    {
        private string _projectName;
        private double _budget;
        private string _contractorName;
        private bool _isActive;

        public Contract() { }

        public Contract(string projectName, double budget, string contractorName, bool isActive)
        {
            this._projectName = projectName;
            this._budget = budget;
            this._contractorName = contractorName;
            this._isActive = isActive;
        }

        // --- EXPLICIT GETTERS AND SETTERS ---
        public string GetProjectName() { return _projectName; }
        public void SetProjectName(string value) { _projectName = value; }

        public double GetBudget() { return _budget; }
        public void SetBudget(double value) { _budget = value; }

        public string GetContractorName() { return _contractorName; }
        public void SetContractorName(string value) { _contractorName = value; }

        public bool GetIsActive() { return _isActive; }
        public void SetIsActive(bool value) { _isActive = value; }

        // --- SERIALIZATION LOGIC (The "Expert" Pattern) ---
        
        // The Contract handles turning itself into a storage format
        public string Serialize()
        {
            return _projectName + "|" + _budget + "|" + _contractorName + "|" + _isActive;
        }

        // The Contract handles rebuilding itself from a storage format
        public void Deserialize(string data)
        {
            string[] parts = data.Split('|');
            this._projectName = parts[0];
            this._budget = double.Parse(parts[1]);
            this._contractorName = parts[2];
            this._isActive = bool.Parse(parts[3]);
        }
    }
}
