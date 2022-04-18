using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Car
    {
        string name;
        public Car(string name)
        {
            this.name = name;
        }
        public override string ToString() => name;
    }
}
