using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class ThreeFuelsAreAvailableSteps
    {
        private int _counter = 0;
        private bool _isGasAvailable;
        private bool _isDieselAvailable;
        private bool _isMethanolAvailable;

        [Given]
        public void GivenILookAtAllFuels()
        {
            var values = Enum.GetValues(typeof(Program.FuelType));

            foreach (Program.FuelType ft in values)
            {
                if (ft == Program.FuelType.Gas) _isGasAvailable = true;
                if (ft == Program.FuelType.Diesel) _isDieselAvailable = true;
                if (ft == Program.FuelType.Methanol) _isMethanolAvailable = true;
                _counter++;
            }
        }
        
        [Then]
        public void ThenThereShouldBeATotalOfThree()
        {
            Assert.True(_counter == 3);
        }
        
        [Then]
        public void ThenMethanolGasAndDieselShouldBeAvailable()
        {
            Assert.True(_isGasAvailable);
            Assert.True(_isMethanolAvailable);
            Assert.True(_isDieselAvailable);
        }
    }
}
