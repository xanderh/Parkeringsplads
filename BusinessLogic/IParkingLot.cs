using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface IParkingLot
    {
        void LeaveParkingLot(Car car);
        void ArriveAtParkingLot(Car car);
        Car FindCar(Car car);
        IReadOnlyList<Car> AllCars();
    }
}
