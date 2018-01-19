using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class EachCarCanFuelUpGoOnSaleAndHonkSteps
    {
        private Program _p = new Program();
        private int _counter;
        private bool _aTestFailed;

        [Given]
        public void GivenICreateACarForEveryCarType()
        {
            var values = Enum.GetValues(typeof(Program.CarType));

            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                _counter++;
            }
        }

        [Given]
        public void GivenILoopThroughThem()
        {
            _counter--;
            while (_counter > -1)
            {
                string response;
                response = _p.CarList[_counter].Drive();
                if (response.Length < 1) _aTestFailed = true;
                response = _p.CarList[_counter].FuelUp();
                if (response.Length < 1) _aTestFailed = true;
                response = _p.CarList[_counter].OnSale();
                if (response.Length < 1) _aTestFailed = true;
                response = _p.CarList[_counter].Honk();
                if (response.Length < 1) _aTestFailed = true;
                _counter--;
            }
        }
        
        [Then]
        public void ThenEachCarShouldBeAbleToHonkGoOnSaleDriveAndFuelUp()
        {
            Assert.IsFalse(_aTestFailed);
        }
    }
}
