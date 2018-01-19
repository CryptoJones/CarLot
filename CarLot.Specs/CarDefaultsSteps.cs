using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarDefaultsSteps
    {
        private Program _p = new Program();
        private int _carTypeCounter = 0;
        private int _startingPrice;
        private int _endingPrice;

        [Given]
        public void GivenICreateACarOfEachType()
        {
            var values = Enum.GetValues(typeof(Program.CarType));

            foreach (Program.CarType ct in values)
            {
                _p.Create(ct);
                _carTypeCounter++;
            }
        }

        [Then]
        public void ThenIfTheCarDoesnTHaveSpecificRulesItShouldFollowTheseDefaults()
        {
            // We should have three cars
            Assert.True(_carTypeCounter == 3);

            // The first should be a pinto
            Assert.True(_p.CarList[0].carType == Program.CarType.Pinto);
             Assert.True(_p.CarList[0].fuelLevel == 14);
            Assert.True(_p.CarList[0].fuelUsage == 3);
            Assert.True(_p.CarList[0].currentPrice == 20000);
            _startingPrice = _p.CarList[0].currentPrice;
            _p.CarList[0].OnSale();
            _endingPrice = _p.CarList[0].currentPrice;
            // Pintos go on sale for 75% off
            Assert.True((double)_startingPrice * .25 == _endingPrice);



            // The second should be a Semi Truck
            Assert.True(_p.CarList[1].carType == Program.CarType.SemiTruck);
            // Semi Trucks have a defaul fuel level of 50
            Assert.True(_p.CarList[1].fuelLevel == 50);
            Assert.True(_p.CarList[1].fuelUsage == 3);
            // SemiTrucks have a default value  of 50000
            Assert.True(_p.CarList[1].currentPrice == 50000);
            _startingPrice = _p.CarList[1].currentPrice;
            _p.CarList[1].OnSale();
            _endingPrice = _p.CarList[1].currentPrice;
            Assert.True((double)_startingPrice * .8 == _endingPrice);


            // The third should be a funny car
            Assert.True(_p.CarList[2].carType == Program.CarType.FunnyCar);
            Assert.True(_p.CarList[2].fuelLevel == 14);
            // Default Fuel usage for Funny Car is Fourteen
            Assert.True(_p.CarList[2].fuelUsage == 14);
            Assert.True(_p.CarList[2].currentPrice == 20000);
            _startingPrice = _p.CarList[2].currentPrice;
            _p.CarList[2].OnSale();
            _endingPrice = _p.CarList[2].currentPrice;
            Assert.True((double)_startingPrice * .8 == _endingPrice);






        }
    }
}
