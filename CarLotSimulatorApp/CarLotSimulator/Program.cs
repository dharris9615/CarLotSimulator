using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            var truck = new Car();
            truck.Make = "Ford";
            truck.Model = "Kingranch";
            truck.Year = 2030;
            truck.EngineNoise = "vroom";
            truck.HonkNoise = "beep beep";
            truck.IsDriveable = true;

            var hybrid = new Car()
            {
                Make = "Toyota",
                Model = "Prius",
                Year = 2017,
                EngineNoise = "...",
                HonkNoise = "tweet tweet",
                IsDriveable = true

            };

            var suv = new Car(2010, "Chevy", "Tahoe", "vroom", "beep", true);




            //Set the properties for each of the cars
            //Call each of the methods for each car

            truck.MakeEngineNoise(truck.EngineNoise);
            truck.MakeHonkNoise(truck.HonkNoise);

            hybrid.MakeEngineNoise(hybrid.EngineNoise);
            hybrid.MakeHonkNoise(hybrid.HonkNoise);

            suv.MakeEngineNoise(suv.EngineNoise);
            suv.MakeHonkNoise(suv.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//


            var onLot = new CarLot();

            onLot.CarList.Add(truck);
            onLot.CarList.Add(hybrid);
            onLot.CarList.Add(suv);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (Car vehicle in onLot.CarList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, was made in {vehicle.Year}" );
            }
           
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
