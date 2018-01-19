using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarLotMaxSteps
    {
        private Program _p = new Program();

        [Given]
        public void GivenIHaveAFullCarlot()
        {

            _p.CarList.Clear();
            for (int i = 0; i < 25; i++)
            {
                _p.Create(Program.CarType.Pinto);
            }
            Assert.AreEqual(_p.CarList.Count, 25);
        }
        
        [When]
        public void WhenITryToAddACar()
        {
            _p.Create(Program.CarType.Pinto);
        }
        
        [Then]
        public void ThenTheNewCarShouldNotBeAdded()
        {
            Assert.AreEqual(_p.CarList.Count, 25);
            _p.CarList.Clear();
        }

    }


}
