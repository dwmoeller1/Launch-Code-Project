using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_helper
{
    public class Job
    {
        protected List<Structure> structures;
        protected List<Tuple<Structure, Structure>> connections;
        protected string jobNumber;

        public Job(string number)
        {
            this.jobNumber = number;
            this.structures = new List<Structure>();
            this.connections = new List<Tuple<Structure, Structure>>();
        }

        public string JobNumber
        {
            get { return jobNumber; }
        }

        public List<Structure> Structures
        {
            get { return structures; }
        }
    }
}
