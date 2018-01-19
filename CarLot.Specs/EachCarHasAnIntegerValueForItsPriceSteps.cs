using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class EachCarHasAnIntegerValueForItsPriceSteps
    {
        private Program _p = new Program();
        [Given]
        public void GivenICreateACarOfEachTypeAndLoopThroughThem()
        {
            var values = Enum.GetValues(typeof(Program.CarType));
            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                Assert.IsInstanceOf<int>(_p.CarList[0].currentPrice);
                _p.CarList.Clear();
            }
        }
        
        [Then]
        public void ThenEachCarShouldHaveAnIntegerValueWithItsPrice()
        {
            var values = Enum.GetValues(typeof(Program.CarType));
            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                Assert.IsTrue(_p.CarList[0].currentPrice > 0);
                _p.CarList.Clear();
            }
        }
    }
}
