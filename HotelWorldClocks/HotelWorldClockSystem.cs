using System.Collections;

namespace HotelWorldClocks
{
    public class HotelWorldClockSystem
    {
        private ArrayList _cityClocks = new ArrayList();

        public void attach(CityClock cityClock)
        {
            this._cityClocks.Add(cityClock);
        }

        public ArrayList getClocks()
        {
            return this._cityClocks;
        }
    }
}