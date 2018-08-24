using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ParkingLot
    {
        private List<Car> _cars = new List<Car>();

        public void LeaveParkingLot(Car car)
        {
            _cars.Remove(car);
        }

        public void ArriveAtParkingLot(Car car)
        {
            _cars.Add(car);
        }

        public Car FindCar(Car car)
        {
            return _cars.Find((carInList) => carInList == car);
        }

        public IReadOnlyList<Car> AllCars()
        {
            return _cars;
        }
    }
}
