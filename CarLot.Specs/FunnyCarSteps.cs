using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class FunnyCarSteps {
        private Program _p = new Program();

        [Given]
        public void GivenIHaveANewFunnyCar()
        {
            _p.Create(Program.CarType.FunnyCar);
        }

        [Then]
        public void ThenItsFuelTypeShouldBeMethanol()
        {
            Assert.IsTrue(_p.CarList[0].fuelType == Program.FuelType.Methanol);
        }
        [Then]
        public void ThenIDriveIt()
        {
            _p.CarList[0].Drive();
        }

        [Then]
        public void ThenTheTankShouldBeEmpty()
        {
            Assert.IsTrue(_p.CarList[0].fuelLevel == 0);
        }
    } 
}
