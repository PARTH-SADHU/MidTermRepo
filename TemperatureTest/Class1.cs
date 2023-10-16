using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170F23;
using NUnit.Framework;


namespace TemperatureTest
{
    [TestFixture]
    public class TempTests
    {
        [Test]
        public void TestTemperatureBoiling()
        {
            // Arrange
            Temp temperatureConverter = new Temp();
            float inputTemperature = 35.0f;

            // Act
            string result = temperatureConverter.TemperatureConverter(inputTemperature);

            // Assert
            Assert.AreEqual("It's Boiling!!", result);
        }

        [Test]
        public void TestTemperatureNice()
        {
            // Arrange
            Temp temperatureConverter = new Temp();
            float inputTemperature = 25.0f;

            // Act
            string result = temperatureConverter.TemperatureConverter(inputTemperature);

            // Assert
            Assert.AreEqual("It's nice today", result);
        }

        [Test]
        public void TestTemperaturePlesant()
        {
            // Arrange
            Temp temperatureConverter = new Temp();
            float inputTemperature = 15.0f;

            // Act
            string result = temperatureConverter.TemperatureConverter(inputTemperature);

            // Assert
            Assert.AreEqual("It's very pleasant", result);
        }

        [Test]
        public void TestTemperatureOutOfRange()
        {
            // Arrange
            Temp temperatureConverter = new Temp();
            float inputTemperature = 45.0f;

            // Act
            string result = temperatureConverter.TemperatureConverter(inputTemperature);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }
    }
}
