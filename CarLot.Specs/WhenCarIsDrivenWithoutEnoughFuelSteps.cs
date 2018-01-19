using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class WhenCarIsDrivenWithoutEnoughFuelSteps
    {
        private Program _p = new Program();
        private string _responseWhenDriven;

        [Given]
        public void GivenIHaveACarWithAnEmptyTank()
        {
            _p.Create(Program.CarType.Pinto);
            _p.CarList[0].fuelLevel = 0;
        }
        
        [Given]
        public void GivenITryToDriveIt()
        {
            _responseWhenDriven = _p.CarList[0].Drive();
        }
        
        [Then]
        public void ThenIWillGetAnErrorMessage()
        {
            Assert.IsTrue(_responseWhenDriven == "Oh No, you are out of fuel");
        }
        
        [Then]
        public void ThenTheFuelLevelWillBeZero()
        {
            Assert.IsTrue(_p.CarList[0].fuelLevel == 0);
        }
    }
}
