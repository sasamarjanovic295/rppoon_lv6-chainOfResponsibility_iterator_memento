using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class BankState
    {
        public string OwnerName { get; }
        public string OwnerAddress { get; }
        public decimal Balance { get; }
        public BankState(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAddress = ownerAddress;
            this.Balance = balance;
        }
    }
}
