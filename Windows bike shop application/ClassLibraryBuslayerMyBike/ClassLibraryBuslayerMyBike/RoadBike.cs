using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBuslayerMyBike
{
    public class RoadBike : Bike
    {
        private double seatHeight;
        private double bikeWeight;

        public double SeatHeight { get => seatHeight; set => seatHeight = value; }
        public double BikeWeight { get => bikeWeight; set => bikeWeight = value; }
        public RoadBike() : base()
        {
            this.seatHeight = 0.0;
            this.bikeWeight = 0.0;
        }

        public RoadBike(long serialNumber, string make, double speed, EnumColor color, Date madeDate, double warrentyYear, double price, double seatHeight, double bikeWeight) : base(serialNumber, make, speed, color, madeDate, warrentyYear, price)
        {
            this.seatHeight = seatHeight;
            this.bikeWeight = bikeWeight;

        }
        public override double GetMaxSpeed()
        {
            return this.speed = 40;
        }
        public override void SpeedUp(double newSpeed)
        {
            if ((speed + newSpeed) < GetMaxSpeed())
            {
                speed += newSpeed;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\t\t" + SeatHeight + "\t\t" + bikeWeight + "\t\t";
        }

    }

}
