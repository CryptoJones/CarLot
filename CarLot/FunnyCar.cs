namespace CarLot
{
    public class FunnyCar : Car
    {

        private Program.CarType _carType = Program.CarType.FunnyCar;
        private Program.FuelType _fuelType = Program.FuelType.Methanol;
        private int _fuelUsage = 14;

        public override Program.CarType carType
        {
            get { return _carType; }
        }
        public override int fuelUsage
        {
            get { return _fuelUsage; }
            set { _fuelUsage = value; }
        }
        public override Program.FuelType fuelType
        {
            get { return _fuelType; }
        }

    }
}
