using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class InventoryReportContainsTotalFuelTypeFuelLevelAndPriceSteps
    {
        private Program _p = new Program();
        private int _carCount;
        private InventoryReport _myReport = new InventoryReport();

        [Given]
        public void GivenIHaveCreatedSomeCars()
        {
            for (int i = 0; i < 26; i++)
            {
                Random _random = new Random();
                int tempInt = _random.Next(0, 3);
                _p.Create((Program.CarType) tempInt);
            }
        }
        
        [When]
        public void WhenIGenerateAnInventoryReport()
        {
            _myReport = _p.InventoryCars();
            _carCount = _myReport.NumberOfCars;
        }
        
        [Then]
        public void ThenItShouldContainTheCarCountFuelTypeFuelLevelAndPrice()
        {
            foreach (InventoryReportItem  iri in _myReport.Inventory)
            {
                Assert.IsNotNull(iri.FuelType);
                Assert.IsNotNull(iri.FuelLevel);
                Assert.IsNotNull(iri.Price);
                
            }
            Assert.IsNotNull(_carCount);
            Assert.IsTrue(_carCount != 0);
        }
    }
}
