using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelWorldClocksTest
{
    [TestClass]
    public class HotelWorldClocksTest
    {
        [TestMethod]
        public void the_time_of_clock_London_should_be_1_after_the_phone_clock_is_set_to_9_Beijing_time()
        {
            //Arrange

            //Act
            phoneClock.setCityClock(londonClock);
            phoneClock.setTime(9);

            //Assert
            Assert.AreEqual(1, londonClock.getTime());
        }
    }
}
