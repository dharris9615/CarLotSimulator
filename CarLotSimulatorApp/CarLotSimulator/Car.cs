﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = Make;
            Model = Model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = IsDriveable;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
