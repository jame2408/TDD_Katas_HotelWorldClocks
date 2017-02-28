namespace HotelWorldClocks
{
    public class PhoneClock
    {
        private int _utcOffset;

        public PhoneClock(int utcOffset)
        {
            this._utcOffset = utcOffset;
        }

        public void setCityClock(CityClock cityClock)
        {

        }

        public void setTime(int time)
        {
            this.CityClock.setUtcZeroTime(time - this._utcOffset);
        }
    }
}