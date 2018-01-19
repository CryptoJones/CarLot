using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarLotSteps
    {
        private Program p;

        [Given]
        public void GivenIHaveACarLot()
        {
           p = new Program();
            NUnit.Framework.Assert.IsEmpty(p.CarList);
        }
        
        [Given]
        public void GivenIHave25CarsInTheLot()
        {
            for (int i = 0; i < 6; i++)
            {
                p.CreateNewPinto();
                p.CreateNewFunnyCar();
                p.CreateNewSemiTruck();
                p.CreateNewPinto();
                p.CreateNewFunnyCar();
            }
           
        }

        [When]
        public void WhenITryToAddAnotherCar()
        {
            p.CreateNewFunnyCar();
        }

        [Then]
        public void ThenThereShouldBeOnly25CarsInTheLot()
        {
            Assert.Equals(p.CarList.Count, 25);
        }
    }
}
