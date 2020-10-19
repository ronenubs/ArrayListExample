using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    public class Subject
    {
        private string subjectDescription;
        private double numberOfUnits;

        public Subject(string subjectDescription, double numberOfUnits)
        {
            this.subjectDescription = subjectDescription;
            this.numberOfUnits = numberOfUnits;
        }

        public override string ToString()
        {
            return subjectDescription + " (" + numberOfUnits + ")";
        }
    }
}
