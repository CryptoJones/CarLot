using System;

namespace CarLot
{
    [Serializable]
    public class Car
    {
        private Program.CarType _carType;
        private int _fuelLevel = 14;
        private int _maxFuelLevel = 14;
        private int _currentPrice = 20000;
        private int _salePercent = 20;
        private Program.FuelType _fuelType = Program.FuelType.Gas;
        private bool _hybrid;
        private bool _carDisabled;
        private int _fuelUsage = 3;
        private Program.FuelType _fuelTypeInseted;

        public Program.FuelType fuelTypeInserted
        {
            get { return _fuelTypeInseted; }
            set { _fuelTypeInseted = value; }
        }
        public virtual int currentPrice
        {
            get { return _currentPrice; }
            set { _currentPrice = value; }
        }
        public virtual int fuelLevel
        {
            get{ return _fuelLevel;  }
            set{ _fuelLevel = value; }
        }
        public virtual int maxFuelLevel
        {
            get { return _maxFuelLevel; }
            set { _maxFuelLevel = value; }
        }
        public virtual int salePercent
        {
            get{return _salePercent;  }
            set{_salePercent = value; }
        }
        public virtual Program.FuelType fuelType 
        {
            get{ return _fuelType; }
            set{ _fuelType = value; }
        }
        public bool hybrid
        {
            get{ return _hybrid;}
            set{ _hybrid = value;}
        }
        public bool carDisabled
        {
            get { return _carDisabled; }
            set { _carDisabled = value;  }
        }
        public virtual int fuelUsage
        {
            get { return _fuelUsage; }
            set { _fuelUsage = value; }
        }

        public virtual Program.CarType carType {
            get { return _carType; }
            set { _carType = value; }
        }

        public string Honk()
        {
            return "Beep";

        }

        public virtual string Drive()
        {
            if (carDisabled) return "This car is disabled and can't be driven.";
            if (hybrid)
                fuelUsage = (fuelUsage - 2);
            
            fuelLevel = (fuelLevel - fuelUsage);

            if (fuelLevel < 0) fuelLevel = 0;

            if (fuelLevel == 0) return "Oh No, you are out of fuel";

            return "Zoom";

        }

        public virtual string FuelUp(Program.FuelType fuelTypeInserted = Program.FuelType.Gas)
        {
            if (fuelTypeInserted != fuelType)
            {
                carDisabled = true;
                return "You have used the wrong fuel the car will no longer start";

            }

            fuelLevel = maxFuelLevel;
            return "The car is now full";

        }

        public virtual string OnSale()
        {
            double dblSalePercent = (double)salePercent;
            double dblOneHundred = 100.00;
            double dblDiscountPercent = (dblSalePercent / dblOneHundred);
            double dblDiscountAmount = ((double)currentPrice * dblDiscountPercent);
            int intDiscountPrice = (currentPrice - (int)dblDiscountAmount);
            currentPrice = intDiscountPrice;
            return "Car is now on sale";
        }
    }
}
