using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carGarage = new Garage();
            Washer carWasher = new Washer();
            GetCarWashed gcw = carWasher.Wash;

            Console.WriteLine("Сколько машин мыть?");
            int carAmount = int.Parse(Console.ReadLine());

            if (carAmount <= 0) Console.WriteLine("Ты чё пришёл? На работу устраиваться?");
            else Console.WriteLine("Буржуй");

            for (int i = 0; i < carAmount; i++)
                carGarage.Add(new Car(Console.ReadLine()));

            foreach (Car car in carGarage.cars)
                gcw(car);
        }

        public delegate void GetCarWashed(Car car);
    }
}
