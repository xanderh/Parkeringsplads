using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Parkeringsplads
{
    public class Actor
    {
        public ParkingLot parkingLot;
        protected bool shouldSleep = Program.shouldSleep;
        protected int sleepInterval = Program.sleepInterval;

        public Actor(ParkingLot parkingLot)
        {
            this.parkingLot = parkingLot;
        }
        public virtual void Run()
        {
            Console.WriteLine("This is the actor base run method. Don't use this.");
        }
    }
}
