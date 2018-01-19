using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class HybridEngineUsesTwoLessFuelUnitsSteps
    {
        private Program _p = new Program();
        [Given]
        public void GivenIHaveCreatedTwoVersionsOfTheSameCar()
        {
            _p.Create(Program.CarType.Pinto);
            _p.Create(Program.CarType.Pinto, true);
            
        }
        
        [Given]
        public void GivenOneIsAHybrid()
        {
            Assert.True(_p.CarList[1].hybrid);
        }
        
        [When]
        public void WhenTheyDrive()
        {
            _p.CarList[0].Drive();
            _p.CarList[1].Drive();
        }
        
        [Then]
        public void ThenTheHybridShouldHaveTwoMoreFuelUnitsThenTheRegularCar()
        {
            Assert.True(_p.CarList[0].fuelLevel +2 == _p.CarList[1].fuelLevel);
        }
    }
}
