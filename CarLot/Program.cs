using System;
using System.Collections.Generic;

namespace CarLot
{
    public class Program
    {
        public enum FuelType
        {
            Gas = 0,
            Diesel = 1,
            Methanol = 2
        }

        public enum CarType
        {
            Pinto = 0,
            SemiTruck = 1,
            FunnyCar = 2
        }

        public List<Car> CarList = new List<Car>();
        public ProgramVariables variables = new ProgramVariables();

        public class ProgramVariables
        {
            public int numberOfCars;
            public int lotMax = 25;
            public string userSelection;
        }

        public InventoryReport InventoryCars()
        {
            InventoryReport myInventoryReport = new InventoryReport();
            int counter = new int();

            foreach (var Car in CarList)
            {
                InventoryReportItem myReportItem = new InventoryReportItem();

                myReportItem.CarNumber = (int)CarList.IndexOf(Car);
                myReportItem.CarType = Car.carType;
                if (Car.hybrid) myReportItem.IsHybrid = true;
                myReportItem.FuelType = Car.fuelType;
                myReportItem.Price = Car.currentPrice;
            
                myReportItem.FuelLevel = Car.fuelLevel;
                myReportItem.Price = Car.currentPrice;

                myInventoryReport.Inventory.Add(myReportItem);

                counter++;
            }
            myInventoryReport.NumberOfCars = counter;
            return myInventoryReport;
        }

        public string Create(Program.CarType carType, bool isHybrid = false)
        {
            switch (carType)
            {
                case CarType.Pinto:

                    Pinto myPinto = new Pinto();
                    myPinto.carType = Program.CarType.Pinto;
                    if (isHybrid) myPinto.hybrid = true;

                    if (variables.numberOfCars < variables.lotMax)
                    {
                        variables.numberOfCars++;
                        CarList.Add(myPinto);

                        if (myPinto.hybrid) return "Hybrid Pinto Created!";

                        return "Pinto Created!";
                    }
                    return "Car Lot full! No car was created!";

                case CarType.FunnyCar:

                    FunnyCar myFunnyCar = new FunnyCar();
                    myFunnyCar.carType = Program.CarType.FunnyCar;
                    if (isHybrid) myFunnyCar.hybrid = true;

                    if (variables.numberOfCars < variables.lotMax)
                    {
                        variables.numberOfCars++;
                        CarList.Add(myFunnyCar);

                        if (myFunnyCar.hybrid) return "Hybrid Funny Car Created!";
                        return "Funny Car Created!";
                    }
                    return "Car Lot full! No car was created!";

                case CarType.SemiTruck:

                    SemiTruck mySemiTruck = new SemiTruck();
                    mySemiTruck.carType = Program.CarType.SemiTruck;
                    if (isHybrid) mySemiTruck.hybrid = true;

                    if (variables.numberOfCars < variables.lotMax)
                    {
                        variables.numberOfCars++;
                        CarList.Add(mySemiTruck);

                        if (mySemiTruck.hybrid) return "Hybrid Semi Truck Created!";

                        return "Semi Truck Created!";
                    }
                    return "Car Lot full! No car was created!";

            }

            return "Car Type not valid! No car created!";
        }
    }
}
