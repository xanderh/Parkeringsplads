using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;

namespace Parkeringsplads
{
    public class Program
    {
        public static bool shouldSleep = true;
        public static int sleepInterval = 500;
        Random random = new Random();
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            Driver driver1 = new Driver(parkingLot);
            Thread.Sleep(sleepInterval);
            Driver driver2 = new Driver(parkingLot);
            Thread.Sleep(sleepInterval);
            Driver driver3 = new Driver(parkingLot);
            Thread.Sleep(sleepInterval);
            Driver driver4 = new Driver(parkingLot);
            Thread.Sleep(sleepInterval);
            Driver driver5 = new Driver(parkingLot);
            Thread.Sleep(sleepInterval);
            Viewer viewer1 = new Viewer(parkingLot);

            driver1.task.Wait();
        }
    }
}
