using NUnit.Framework;

namespace SampleDotNetWebAPI.Test
{
    public class WeatherForecastTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestGetCityTemperature()
        {
            //Arrange
            int expected = 24;
            var weatherForecast = new WeatherForecast();
            //Act
            int actual = weatherForecast.GetCityTemperature();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}