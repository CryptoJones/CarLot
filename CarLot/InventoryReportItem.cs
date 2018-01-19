using System;

namespace CarLot
{
    [Serializable]
    public class InventoryReportItem
    {
        private int _carNumber;
        private Program.CarType _carType;
        private bool _isHybrid;
        private int _fuelLevel;
        private int _price;

        public int CarNumber
        {
            get { return _carNumber; }

            set { _carNumber = value; }
        }

        public Program.CarType CarType
        {
            get { return _carType; }

            set { _carType = value; }
        }

        public bool IsHybrid
        {
            get { return _isHybrid; }

            set { _isHybrid = value; }
        }

        public int FuelLevel
        {
            get { return _fuelLevel; }

            set { _fuelLevel = value; }
        }

        public Program.FuelType FuelType { get; set; }

        public int Price
        {
            get { return _price; }

            set { _price = value; }
        }
    }
}
