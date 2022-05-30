using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Memento
{
    class CareTaker
    {
        public List<Memento> previousStates;
        public CareTaker()
        {
            previousStates = new List<Memento>();
        }
        public void AddState(Memento state) { previousStates.Add(state); }
        public Memento GetFirstState() { return previousStates.OrderByDescending(s => s.CreationTime).First(); }
        public Memento GetLastState() { return previousStates.OrderBy(s => s.CreationTime).First(); }
    }
}
