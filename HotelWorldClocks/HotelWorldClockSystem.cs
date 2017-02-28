using System.Collections.Generic;

namespace HotelWorldClocks
{
    public class HotelWorldClockSystem
    {
        private IEnumerable<CityClock> _cityClocks;

        public void attach(CityClock cityClock)
        {

        }

        public IEnumerable<CityClock> getClocks()
        {
            return this._cityClocks;
        }
    }
}