﻿using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {

        }

        public static int numberOfCars = 1;

        public List<Car> carList { get; set; } = new List<Car>();
    }
}
