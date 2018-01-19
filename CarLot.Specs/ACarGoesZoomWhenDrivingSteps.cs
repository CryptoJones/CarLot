using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class ACarGoesZoomWhenDrivingSteps
    {
        private Program _p;
        private string carResponse;

        [Given]
        public void GivenIHaveCreatedANewCarlot()
        {
            _p = new Program();
        }

        [When]
        public void WhenICreateACar()
        {
            _p.Create(Program.CarType.Pinto);
        }

        [When(@"I drive it")]
        public void WhenIDriveIt()
        {
            carResponse = _p.CarList[0].Drive();
        }
        
        [Then(@"it should go zoom")]
        public void ThenItShouldGoZoom()
        {
            Assert.True(carResponse == "Zoom");
        }
    }
}
