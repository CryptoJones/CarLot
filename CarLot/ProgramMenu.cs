using System;
using System.Collections.Generic;

namespace CarLot
{
    public class ProgramMenu
    {
        static void Main()
        {
            Program p = new Program();
            string userSelection;
            bool stopRun = new bool();
            while (!stopRun)
            {
                Menu();

                userSelection = Console.ReadLine().ToUpper();

                switch (userSelection)
                {
                    case "0":
                        stopRun = true;
                        break;
                    case "1":
                    {
                        string response = p.Create(Program.CarType.Pinto);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "2":
                    {
                        string response = p.Create(Program.CarType.SemiTruck);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "3":
                    {
                        string response = p.Create(Program.CarType.FunnyCar);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "4":
                    {
                        string response = p.Create(Program.CarType.Pinto, true);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "5":
                    {
                        string response = p.Create(Program.CarType.SemiTruck, true);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "6":
                    {
                        string response = p.Create(Program.CarType.FunnyCar, true);
                        Console.WriteLine(response);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case "D":
                    {
                        Console.Write("Enter car number to drive: ");
                        string tempString = Console.ReadLine();
                        if (isValidCarSelection(tempString, p.CarList.Count))
                        {
                            string response = p.CarList[Int32.Parse(tempString)].Drive();
                            Console.WriteLine(response);
                            Console.WriteLine("Press any key to contine...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection made! Returning to main menu...");
                            Console.WriteLine("Press any key to contine...");
                            Console.ReadLine();
                        }
                    }
                        break;
                    case "F":
                    {
                        Console.Write("Enter car number to fuel: ");
                        string tempString = Console.ReadLine();
                        if (isValidCarSelection(tempString, p.CarList.Count))
                        {
                            FuelUpACar(ref p.CarList, Int32.Parse(tempString));
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection made! Returning to main menu...");
                            Console.ReadLine();
                        }
                    }
                        break;
                    case "H":
                    {
                        Console.Write("Enter car number to honk: ");
                        string tempString = Console.ReadLine();
                        if (isValidCarSelection(tempString, p.CarList.Count))
                        {
                            string response = p.CarList[Int32.Parse(tempString)].Honk();
                            Console.WriteLine(response);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection made! Returning to Main Menu...");
                            Console.ReadLine();
                        }
                    }
                        break;
                    case "S":
                    {
                        Console.Write("Enter car number to drive: ");
                        string tempString = Console.ReadLine();
                        if (isValidCarSelection(tempString, p.CarList.Count))
                        {
                            p.CarList[Int32.Parse(tempString)].OnSale();
                            Console.WriteLine("Car has been discounted! Returning to main menu...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection made! Returning to main menu...");
                            Console.ReadLine();
                        }
                    }
                        break;
                    case "L":
                        InventoryReport myInventoryReport = p.InventoryCars();
                        foreach (InventoryReportItem iri in myInventoryReport.Inventory)
                        {
                            Console.WriteLine("Car number: " + iri.CarNumber);
                            Console.WriteLine("Car type: " + iri.CarType);
                            Console.WriteLine("Hybrid: " + (iri.IsHybrid ? "Yes" : "No"));
                            Console.WriteLine("Fuel type: " + iri.FuelType);
                            Console.WriteLine("Fuel Level: " + iri.FuelLevel);
                            Console.WriteLine("Price: " + iri.Price);
                            Console.WriteLine(String.Empty);
                        }
                        Console.WriteLine("Total Number of Cars in Lot: " + myInventoryReport.NumberOfCars);

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection! Enter any key to continue....");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public static void FuelUpACar(ref List<Car> carList, int carNumber)
        {
            Console.WriteLine("Fuel Types");
            Console.WriteLine("1) Gas");
            Console.WriteLine("2) Diesel");
            Console.WriteLine("3) Methanol");
            Console.Write("Enter fueltype number: ");
            string tempStr0 = Console.ReadLine();
            if (tempStr0 == "1")
            {
                string response = carList[carNumber].FuelUp(Program.FuelType.Gas);
                Console.WriteLine(response);
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else if (tempStr0 == "2")
            {
                string response = carList[carNumber].FuelUp(Program.FuelType.Diesel);
                Console.WriteLine(response);
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else if (tempStr0 == "3")
            {
                string response = carList[carNumber].FuelUp(Program.FuelType.Methanol);
                Console.WriteLine(response);
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Type!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|                           Lot Master 3000                                   |");
            Console.WriteLine("|                           ---------------                                   |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|      1) Add Pinto                                                           |");
            Console.WriteLine("|      2) Add SemiTruck                                                       |");
            Console.WriteLine("|      3) Add FunnyCar                                                        |");
            Console.WriteLine("|      4) Add Pinto (Hybrid)                                                  |");
            Console.WriteLine("|      5) Add SemiTruck (Hybrid)                                              |");
            Console.WriteLine("|      6) Add FunnyCar (Hybrid)                                               |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|      D) Drive a Car                                                         |");
            Console.WriteLine("|      F) Fuel Up a Car                                                       |");
            Console.WriteLine("|      H) Honk a Car                                                          |");
            Console.WriteLine("|      S) Mark car 'On Sale'                                                  |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|      L) List all Cars on Lot                                                |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|      0) Exit Program                                                        |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Write("Enter Selection: ");
        }

        public static bool isValidCarSelection(string input, int numberOfCarsOnLot)
        {
            if (input.Length == 0) return false;

            try
            {
                int tempInt0 = Int32.Parse(input);
            }
            catch
            {
                return false;
            }

            if (Int32.Parse(input) < numberOfCarsOnLot && Int32.Parse(input) > -1) return true;

            return false;
        }

    }
}

