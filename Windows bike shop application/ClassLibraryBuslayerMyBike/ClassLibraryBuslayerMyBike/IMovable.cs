﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBuslayerMyBike
{
    interface IMovable
    {
        double GetMaxSpeed();
        void SpeedUp(double newSpeed);

    }
}
