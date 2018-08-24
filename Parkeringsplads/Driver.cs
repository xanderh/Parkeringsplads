using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;

namespace Parkeringsplads
{
    public class Driver : Actor
    {
        Car car;
        public Task task;
        
        public Driver(ParkingLot parkingLot) : base(parkingLot)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string regNr = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            this.car = new Car(regNr);

            task = new Task(Run);
            task.Start();
        }



        public override void Run()
        {
            while(true)
            {
                parkingLot.ArriveAtParkingLot(car);
                if(shouldSleep)
                {
                    Thread.Sleep(sleepInterval);
                }
                parkingLot.LeaveParkingLot(car);
                if(shouldSleep)
                {
                    Thread.Sleep(sleepInterval);
                }
            }
        }
    }
}
