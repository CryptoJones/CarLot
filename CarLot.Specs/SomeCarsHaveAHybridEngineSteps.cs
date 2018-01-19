using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class SomeCarsHaveAHybridEngineSteps
    {
        private Program _p;

        [Given]
        public void GivenIHaveACarLot()
        {
            _p = new Program();
        }
        
        [Given]
        public void GivenIAddCarWithTheHybridOption()
        {
            _p.Create(Program.CarType.Pinto, true);
        }
        
        [Then]
        public void ThenItShouldBeAHybrid()
        {
            Assert.True(_p.CarList[0].hybrid);
        }
    }
}
