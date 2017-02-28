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
            //當地時間 = UTC時間 + (當地時間與UTC時間的時差)
            return this._utcZeroTime + this._utcOffset;
        }
    }
}