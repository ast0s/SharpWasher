using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Garage
    {
        public List<Car> cars = new List<Car>();
        public Garage(){}
        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }
        public void Add(Car newCar) => cars.Add(newCar);
    }
}
