namespace CarLot
{
    public class Pinto : Car
    {
        private int _salePercent = 75;
      
        public override int salePercent
        {
            get{ return _salePercent;}
            set{ _salePercent = value;}
        }
        
    }
}
