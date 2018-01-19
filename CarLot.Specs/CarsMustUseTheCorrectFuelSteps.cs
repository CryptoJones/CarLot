using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarsMustUseTheCorrectFuelSteps
    {
        private Program _p = new Program();
        private string _pintoResponse;
        private string _funnyCarResponse;
        private string _semiTruckResponse;

        [Given]
        public void GivenIHaveCreatedThreeDifferentCars()
        {
            _p.Create(Program.CarType.Pinto);
            _p.Create(Program.CarType.FunnyCar);
            _p.Create(Program.CarType.SemiTruck);

            Assert.True(_p.CarList.Count == 3);
        }
        
        [Given]
        public void GivenITryToFuelThemUpWithTheWrongFuel()
        {
            // Pintos take gas
            Assert.True(_p.CarList[0].carType == Program.CarType.Pinto);
            _pintoResponse = _p.CarList[0].FuelUp(Program.FuelType.Methanol);
            // Funny Cars take methanol
            Assert.True(_p.CarList[1].carType == Program.CarType.FunnyCar);
            _funnyCarResponse = _p.CarList[1].FuelUp(Program.FuelType.Diesel);
            // Semi Trucks take diesel
            Assert.True(_p.CarList[2].carType == Program.CarType.SemiTruck);
            _semiTruckResponse = _p.CarList[2].FuelUp(Program.FuelType.Methanol);
        }
        
        [Then]
        public void ThenTheyShouldBeDisabled()
        {
            Assert.True(_p.CarList[0].carDisabled);
            Assert.True(_p.CarList[1].carDisabled);
            Assert.True(_p.CarList[2].carDisabled);
        }
        
        [Then]
        public void ThenIShouldReceiveAnErrorMessage()
        {
            Assert.True(_pintoResponse == "You have used the wrong fuel the car will no longer start");
            Assert.True(_funnyCarResponse == "You have used the wrong fuel the car will no longer start");
            Assert.True(_semiTruckResponse == "You have used the wrong fuel the car will no longer start");
        }
    }
}
