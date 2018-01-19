using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class DifferentCarsTakeDifferentFuelsSteps
    {
        private Program _p = new Program();

        private Program.FuelType _pintoFuel = Program.FuelType.Gas;
        private Program.FuelType _funnyCarFuel = Program.FuelType.Methanol;
        private Program.FuelType _semiTruckFuel = Program.FuelType.Diesel;

        private Program.FuelType _fuelThatWorksInPintos;
        private Program.FuelType _fuelThatWorksInFunnyCars;
        private Program.FuelType _fuelThatWorksInSemiTrucks;

        [Given]
        public void GivenIHaveCreatedThreeCarsOfDifferentTypes()
        {
            _p.Create(Program.CarType.Pinto);
            _p.Create(Program.CarType.FunnyCar);
            _p.Create(Program.CarType.SemiTruck);
        }
        
        [Then]
        public void ThenEachCarShouldTakeADifferentFuel()
        {
            var values = Enum.GetValues(typeof(Program.FuelType));

            foreach (Program.FuelType ft in values)
            {
                string pintoResponse = _p.CarList[0].FuelUp(ft);

                if (pintoResponse == "The car is now full") _fuelThatWorksInPintos = ft;

                string funnyCarResponse = _p.CarList[1].FuelUp(ft);

                if (funnyCarResponse == "The car is now full") _fuelThatWorksInFunnyCars = ft;

                string semiTruckResponse = _p.CarList[2].FuelUp(ft);

                if (semiTruckResponse == "The car is now full") _fuelThatWorksInSemiTrucks = ft;

            }

            Assert.IsTrue(_pintoFuel == _fuelThatWorksInPintos);
            Assert.IsTrue(_funnyCarFuel == _fuelThatWorksInFunnyCars);
            Assert.IsTrue(_semiTruckFuel == _fuelThatWorksInSemiTrucks);
            
        }
    }
}
