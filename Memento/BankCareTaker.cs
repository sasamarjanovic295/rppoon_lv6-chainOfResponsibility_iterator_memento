using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Memento
{
    class BankCareTaker
    {
            public List<BankState> previousStates;
            public BankCareTaker()
            {
                previousStates = new List<BankState>();
            }
            public void AddState(BankState state) { previousStates.Add(state); }
            public BankState GetFirstState() { return previousStates.First(); }
            public BankState GetLastState() { return previousStates.Last(); }
    }
}
