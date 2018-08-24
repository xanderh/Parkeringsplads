using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Car
    {
        private string RegNr { get; set; }
        public Car(string regNr)
        {
            RegNr = regNr;
        }

        public override string ToString()
        {
            return RegNr;
        }
    }
}
