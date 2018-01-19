using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class TheLotContainsCarsSteps
    {
        private Program _p = new Program();
        [Given]
        public void GivenIHaveCarLot()
        {
            Assert.True(_p.CarList.Count == 0);
        }
        
        [Then]
        public void ThenICanAddACar()
        {
            bool CarAdded;
            try
            {
                _p.Create(Program.CarType.Pinto);
                CarAdded = true;
            }
            catch
            {
                CarAdded = false;
            }
            Assert.True(CarAdded);
        }
    }
}
