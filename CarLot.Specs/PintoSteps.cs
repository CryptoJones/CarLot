using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class PintoSteps
    {
        private Program _p = new Program();
        private string _fuelResponse;
        private int _originalPrice;
        private int _discountedPrice;

        [Given]
        public void GivenIHaveCreatedANewPinto()
        {
            _p.Create(Program.CarType.Pinto);
            Assert.True(_p.CarList.Count == 1);
        }
        
        [Given]
        public void GivenIFuelItUpWithGas()
        {
            _fuelResponse = _p.CarList[0].FuelUp(Program.FuelType.Gas);
        }
        
        [Then]
        public void ThenTheResultShouldBeTheCarIsFueled()
        {
            Assert.True(_fuelResponse == "The car is now full");
        }
        
        [Then]
        public void ThenWhenIDiscountIt()
        {
            _originalPrice = _p.CarList[0].currentPrice;
            _p.CarList[0].OnSale();
            _discountedPrice = _p.CarList[0].currentPrice;
        }
        
        [Then]
        public void ThenThePriceShouldBe25PercentOfTheOriginalPrice()
        {
            Assert.True(_originalPrice == _discountedPrice * 4);
        }
    }
}
