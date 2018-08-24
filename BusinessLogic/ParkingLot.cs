using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ParkingLot : IParkingLot
    {
        private List<Car> _cars = new List<Car>();
        object _lock = new object();

        public void LeaveParkingLot(Car car)
        {
            lock (_lock)
            {
                _cars.Remove(car);
                Console.WriteLine($"Car with registration number {car} left");

            }
        }

        public void ArriveAtParkingLot(Car car)
        {
            lock (_lock)
            {

                _cars.Add(car);
                Console.WriteLine($"Car with registration number {car} arrived");
            }
        }

        public Car FindCar(Car car)
        {
            lock (_lock)
            {

                return _cars.Find((carInList) => carInList == car);
            }
        }

        public IReadOnlyList<Car> AllCars()
        {
            lock (_lock)
            {
                List<Car> cars = new List<Car>();
                cars.AddRange(_cars);
                return cars;
            }
        }
    }
}
