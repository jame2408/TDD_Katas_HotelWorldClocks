namespace HotelWorldClocks
{
    public class CityClock
    {
        private int _utcOffset;

        public CityClock(int utcOffset)
        {
            this._utcOffset = utcOffset;
        }

        public int getTime()
        {
            return 1;
        }
    }
}