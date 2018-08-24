using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;

namespace Parkeringsplads
{
    public class Viewer : Actor
    {
        public Task task;
        public Viewer(ParkingLot parkingLot) : base(parkingLot)
        {
            task = new Task(Run);
            task.Start();
        }

        public override void Run()
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("cars in parking lot: " + String.Join(", ", parkingLot.AllCars()));
                if (shouldSleep)
                {
                    Thread.Sleep(random.Next(sleepInterval/3, sleepInterval));
                }
            }
        }
    }
}
