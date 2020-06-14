using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBuslayerMyBike
{

      [Serializable]

   
    public abstract class Bike:IMovable
    {
        private long serialNumber;
        protected string make;
        protected double speed;
        protected EnumColor color;
        protected Date madeDate;
        protected double warrentyYear;
        protected double price;

        public long SerialNumber { get => serialNumber; set => serialNumber = value; }
        public Bike()
        {
            this.serialNumber = 0;
        }

        public Bike(long serialNumber, string make, double speed, EnumColor color, Date madeDate,double warrentyYear, double price)
        {
            this.serialNumber = serialNumber;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.madeDate = madeDate;
            this.warrentyYear = warrentyYear;
            this.price = price;
        }

        public virtual double GetMaxSpeed()
        {
            return this.speed = 20.00;
        }

        public abstract void SpeedUp(double newSpeed);
   

        public override string ToString()
        {
            return SerialNumber +
            "\t" + make +
            "\t\t" + speed +
            "\t\t" + color + "\t\t" + price + "\t\t" + warrentyYear +
            "\t\t" + madeDate.ToString();
        }
    
    
    
    
    }
}
