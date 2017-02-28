namespace HotelWorldClocks
{
    public class PhoneClock
    {
        private int _utcOffset;
        private HotelWorldClockSystem _hotelWorldClockSystem;

        public PhoneClock(int utcOffset)
        {
            this._utcOffset = utcOffset;
        }
        

        public void setTime(int time)
        {
            foreach (CityClock cityClock in this._hotelWorldClockSystem.getClocks())
            {
                cityClock.setUtcZeroTime(time - this._utcOffset);
            }
        }

        public void setHotelWorldClockSystem(HotelWorldClockSystem hotelWorldClockSystem)
        {
            this._hotelWorldClockSystem = hotelWorldClockSystem;
        }
    }
}