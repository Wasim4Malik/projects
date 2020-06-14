using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBuslayerMyBike
{
    public class MountainBike : Bike
    {
        private double groundHeight;
        private EnumSuspension suspensionType;
        private int numberofgears;


        public double GroundHeight { get => groundHeight; set => groundHeight = value; }
        public EnumSuspension SuspensionType { get => suspensionType; set => suspensionType = value; }
        public int Numberofgears { get => numberofgears; set => numberofgears = value; }
        public MountainBike() : base()
        {
            this.groundHeight = 0.0;
            this.suspensionType = EnumSuspension.Front;
            this.numberofgears = 0;
        }
        public MountainBike(long serialNumber, string make, double speed, EnumColor color, Date madeDate, double warrentyYear, double price, double groundHeight, EnumSuspension suspensionType, int numberofgears) : base(serialNumber, make, speed, color, madeDate, warrentyYear, price)
        {
            this.groundHeight = groundHeight;
            this.suspensionType = suspensionType;
            this.numberofgears = numberofgears;
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
            return base.ToString() + "\t\t-\t\t" + "\t\t" + suspensionType + "\t\t" + groundHeight + "\t\t" + numberofgears;
        }


    }
}
