namespace CarLot
{
    public class SemiTruck : Car
    {
        private int _fuelLevel = 50;
        private int _maxFuelLevel = 50;
        private Program.FuelType _fuelType = Program.FuelType.Diesel;
        private int _currentPrice = 50000;

        public override int currentPrice
        {
            get { return _currentPrice; }
            set { _currentPrice = value; }
        }

        public override int fuelLevel
        {
            get { return _fuelLevel; }
            set { _fuelLevel = value; }
        }

        public override int maxFuelLevel
        {
            get { return _maxFuelLevel; }
            set { _maxFuelLevel = value; }
        }

        public override Program.FuelType fuelType
        {
            get { return _fuelType; }
            set { _fuelType = value;}
        }
    }
}
