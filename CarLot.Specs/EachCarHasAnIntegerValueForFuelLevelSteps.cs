using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class EachCarHasAnIntegerValueForFuelLevelSteps
    {
        private Program _p = new Program();
        [Given]
        public void GivenILoopThroughEachCarType()
        {
            var values = Enum.GetValues(typeof(Program.CarType));
            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                Assert.IsInstanceOf<int>(_p.CarList[0].fuelLevel);
                _p.CarList.Clear();
            }
        }

        [Then]
        public void ThenAnIntergerValueShouldBePresentForEach()
        {
            var values = Enum.GetValues(typeof(Program.CarType));
            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                Assert.IsTrue(_p.CarList[0].fuelLevel > 0);
                _p.CarList.Clear();
            }
        }
    }
}
