using System.Collections.Generic;

namespace HotelWorldClocks
{
    public class HotelWorldClockSystem
    {
        public void attach(CityClock cityClock)
        {

        }

        public IEnumerable<CityClock> getClocks()
        {
            return this.cityClocks;
        }
    }
}