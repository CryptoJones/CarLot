using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class SemiTruckSteps
    {
        private Program _p = new Program();

        [Given]
        public void GivenIHaveANewSemitruck()
        {
            _p.Create(Program.CarType.SemiTruck);
        }
        
        [Then]
        public void ThenItsCostShouldBe50K()
        {
            Assert.IsTrue(_p.CarList[0].currentPrice == 50000);
        }
        
        [Then]
        public void ThenItsFuelTankShouldBe50Units()
        {
            Assert.IsTrue(_p.CarList[0].fuelLevel == 50);
        }
        
        [Then]
        public void ThenItsFuelTypeShouldBeDiesel()
        {
            Assert.IsTrue(_p.CarList[0].fuelType == Program.FuelType.Diesel);
        }
    }
}
