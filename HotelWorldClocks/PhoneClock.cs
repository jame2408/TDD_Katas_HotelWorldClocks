namespace HotelWorldClocks
{
    public class PhoneClock
    {
        private int _utcOffset;
        private CityClock _cityClock;

        public PhoneClock(int utcOffset)
        {
            this._utcOffset = utcOffset;
        }

        public void setCityClock(CityClock cityClock)
        {
            this._cityClock = cityClock;
        }

        public void setTime(int time)
        {
            this._cityClock.setUtcZeroTime(time - this._utcOffset);
        }
    }
}