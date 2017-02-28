using HotelWorldClocks;
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
            CityClock londonClock = new CityClock(0);
            PhoneClock phoneClock = new PhoneClock(8);
            HotelWorldClockSystem hotelWorldClockSystem = new HotelWorldClockSystem();
            hotelWorldClockSystem.attach(londonClock);

            //Act
            phoneClock.setHotelWorldClockSystem(hotelWorldClockSystem);
            phoneClock.setTime(9);

            //Assert
            Assert.AreEqual(1, londonClock.getTime());
        }

        [TestMethod]
        public void the_time_of_clock_NewYork_should_be_20_after_the_phone_clock_is_set_to_9_Beijing_time()
        {
            //Arrange
            CityClock newYorkClock = new CityClock(-5);
            PhoneClock phoneClock = new PhoneClock(8);
            HotelWorldClockSystem hotelWorldClockSystem = new HotelWorldClockSystem();
            hotelWorldClockSystem.attach(newYorkClock);

            //Act
            phoneClock.setHotelWorldClockSystem(hotelWorldClockSystem);
            phoneClock.setTime(9);

            //Assert
            Assert.AreEqual(20, newYorkClock.getTime());
        }

        [TestMethod]
        public void the_time_of_clock_London_and_NewYork_should_be_1_and_20_respectively_after_the_phone_clock_is_set_to_9_Beijing_time()
        {
            //Arrange
            CityClock londonClock = new CityClock(0);
            CityClock newYorkClock = new CityClock(-5);

            HotelWorldClockSystem hotelWorldClockSystem = new HotelWorldClockSystem();
            hotelWorldClockSystem.attach(londonClock);
            hotelWorldClockSystem.attach(newYorkClock);

            PhoneClock phoneClock = new PhoneClock(8);

            //Act
            phoneClock.setHotelWorldClockSystem(hotelWorldClockSystem);
            phoneClock.setTime(9);

            //Assert
            Assert.AreEqual(1, londonClock.getTime());
            Assert.AreEqual(20, newYorkClock.getTime());
        }

        [TestMethod]
        public void the_time_of_the_phone_clock_should_be_set_correctly_after_its_setTime_method_is_invoked()
        {
            //Arrange
            PhoneClock phoneClock = new PhoneClock(8);

            //Act
            phoneClock.setTime(9);

            //Assert
            Assert.AreEqual(9, phoneClock.getTime());
        }
    }
}
