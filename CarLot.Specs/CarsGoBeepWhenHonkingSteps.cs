using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarsGoBeepWhenHonkingSteps
    {
        private Program _p = new Program();
        private string _carReponse;
        [Given]
        public void GivenIHaveACar()
        {
            _p.Create(Program.CarType.Pinto);
        }
        
        [Given]
        public void GivenIHonkIt()
        {
            _carReponse = _p.CarList[0].Honk();
        }
        
        [Then]
        public void ThenItShouldGoBeep()
        {
            Assert.IsTrue(_carReponse == "Beep");
        }
    }
}
