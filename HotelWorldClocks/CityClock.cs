using System;

namespace HotelWorldClocks
{
    public class CityClock : Clock
    {
        private int _utcZeroTime;

        public CityClock(int utcOffset)
        {
            _utcOffset = utcOffset;
        }

        public int getTime()
        {
            //當地時間 = UTC時間 + (當地時間與UTC時間的時差)
            return (this._utcZeroTime + _utcOffset + 24) % 24;
        }

        internal void setUtcZeroTime(int utcZeroTime)
        {
            _utcZeroTime = utcZeroTime;
        }
    }
}