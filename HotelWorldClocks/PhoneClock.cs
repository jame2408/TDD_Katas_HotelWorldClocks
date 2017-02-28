namespace HotelWorldClocks
{
    public class PhoneClock : Clock
    {
        private HotelWorldClockSystem _hotelWorldClockSystem;

        public PhoneClock(int utcOffset)
        {
            _utcOffset = utcOffset;
        }


        public void setTime(int time)
        {
            if (this._hotelWorldClockSystem == null)
            {
                return;
            }
            foreach (CityClock cityClock in this._hotelWorldClockSystem.getClocks())
            {
                cityClock.setUtcZeroTime(time - _utcOffset);
            }
        }

        public void setHotelWorldClockSystem(HotelWorldClockSystem hotelWorldClockSystem)
        {
            this._hotelWorldClockSystem = hotelWorldClockSystem;
        }

        public int getTime()
        {
            return this.time;
        }
    }
}