﻿using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {

        }

        public static int numberOfCars = 0;

        public List<Car> CarList { get; set; } = new List<Car>();
    }
}
