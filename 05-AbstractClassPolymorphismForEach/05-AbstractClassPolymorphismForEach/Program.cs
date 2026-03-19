class Program
{
    static void Main()
    {
        // Cars
        Car car1 = new Car("Lada", "07", 2023, "10-AA-010", 4, 500, true, 220);
        Car car2 = new Car("BMW", "M5", 2022, "10-AA-000", 4, 480, true, 235);
        Car car3 = new Car("Toyota", "Camry", 2021, "10-AA-100", 4, 524, true, 210);

        // Motorcycles
        Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "10-BB-001", 998, false, 299, "Sport");
        Motorcycle moto2 = new Motorcycle("Harley-Davidson", "Cruiser", 2022, "10-BB-002", 1868, true, 180, "Cruiser");

        // Trucks
        Truck truck1 = new Truck("MAN", "TGX", 2020, "10-CC-001", 18, 3, 12, 120);
        Truck truck2 = new Truck("Volvo", "FH16", 2021, "10-CC-002", 25, 4, 18, 110);

        // Show info + fuel cost
        car1.ShowCarInfo();
        Console.WriteLine("Fuel Cost (500 km): " + car1.CalculateFuelCost(500));

        car2.ShowCarInfo();
        Console.WriteLine("Fuel Cost (500 km): " + car2.CalculateFuelCost(500));

        car3.ShowCarInfo();
        Console.WriteLine("Fuel Cost (500 km): " + car3.CalculateFuelCost(500));

        moto1.ShowMotorcycleInfo();
        Console.WriteLine("Fuel Cost (300 km): " + moto1.CalculateFuelCost(300));

        moto2.ShowMotorcycleInfo();
        Console.WriteLine("Fuel Cost (300 km): " + moto2.CalculateFuelCost(300));

        truck1.ShowTruckInfo();
        Console.WriteLine("Fuel Cost (800 km): " + truck1.CalculateFuelCost(800));

        truck2.ShowTruckInfo();
        Console.WriteLine("Fuel Cost (800 km): " + truck2.CalculateFuelCost(800));

        // Load cargo
        truck1.LoadCargo(5);
        Console.WriteLine("New Fuel Cost: " + truck1.CalculateFuelCost(800));

        // Statistics
        int totalVehicles = 7;

        double avgSpeed =
            (car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed +
             moto1.MaxSpeed + moto2.MaxSpeed +
             truck1.MaxSpeed + truck2.MaxSpeed) / 7.0;

        double maxFuelCost = Math.Max(
            Math.Max(car1.CalculateFuelCost(500), car2.CalculateFuelCost(500)),
            Math.Max(
                Math.Max(car3.CalculateFuelCost(500), moto1.CalculateFuelCost(300)),
                Math.Max(
                    Math.Max(moto2.CalculateFuelCost(300), truck1.CalculateFuelCost(800)),
                    truck2.CalculateFuelCost(800)
                )
            )
        );

        Console.WriteLine("\n--- STATISTICS ---");
        Console.WriteLine("Total Vehicles: " + totalVehicles);
        Console.WriteLine("Average Max Speed: " + avgSpeed);
        Console.WriteLine("Most Expensive Fuel Cost: " + maxFuelCost);
    }
}
