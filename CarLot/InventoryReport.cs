using System;
using System.Collections.Generic;

namespace CarLot
{
    public class InventoryReport
    {
        public List<InventoryReportItem> Inventory = new List<InventoryReportItem>();
        private int _numberOfCars;

        public int NumberOfCars
        {
            get { return _numberOfCars; }

            set { _numberOfCars = value; }
        }
    }
}
