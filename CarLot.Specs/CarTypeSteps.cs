using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarLot.Specs
{
    [Binding]
    public class CarTypeSteps 
    {
        private Program _p = new Program();

        [Given]
        public void GivenIHaveALot()
        {
            
            _p.CarList.Clear();
            Assert.IsEmpty(_p.CarList);

        }
        [When]
        public void WhenICreateACarOfEachType()
        {
            _p.Create(Program.CarType.FunnyCar);
            _p.Create(Program.CarType.Pinto);
            _p.Create(Program.CarType.SemiTruck);
        }
        
        [Then]
        public void ThenIShouldHaveThreeTypesOfCars()
        {
            bool haveAPinto = false;
            bool haveAFunnyCar = false;
            bool haveASemiTruck = false;

            foreach (Car car in _p.CarList){
                if (car.carType == Program.CarType.Pinto)
                {
                    haveAPinto = true;
                }
                if (car.carType == Program.CarType.FunnyCar)
                {
                    haveAFunnyCar = true;
                }
                if (car.carType == Program.CarType.SemiTruck)
                {
                    haveASemiTruck = true;
                }
            }

            Assert.IsTrue(haveASemiTruck);
            Assert.IsTrue(haveAPinto);
            Assert.IsTrue(haveAFunnyCar);
        }


    }
}
