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
        private Temp temperatureConverter;

        [SetUp]
        public void Setup()
        {
            temperatureConverter = new Temp();
        }

        [Test]
        public void TestBoilingTemperature()
        {
            float boilingTemp = 40.0f;
            string result = temperatureConverter.TemperatureConverter(boilingTemp);
            Assert.AreEqual("It's Boiling!!", result);
        }

        [Test]
        public void TestEdgeCaseMaximumTemperature()
        {
            float edgeMaxTemp = 40.0f;
            string result = temperatureConverter.TemperatureConverter(edgeMaxTemp);
            Assert.AreEqual("It's Boiling!!", result);
        }

        [Test]
        public void TestAboveNiceTemperature()
        {
            float aboveNiceTemp = 30.0f;
            string result = temperatureConverter.TemperatureConverter(aboveNiceTemp);
            Assert.AreEqual("It's Boiling!!", result);
        }



        [Test]
        public void TestNiceTemperature()
        {
            float niceTemp = 25.0f;
            string result = temperatureConverter.TemperatureConverter(niceTemp);
            Assert.AreEqual("It's nice today", result);
        }

        [Test]
        public void TestEdgeCaseAbovePleasantTemperature()
        {
            float edgeAbovePleasantTemp = 20.0f;
            string result = temperatureConverter.TemperatureConverter(edgeAbovePleasantTemp);
            Assert.AreEqual("It's nice today", result);
        }

        [Test]
        public void TestEdgeCaseAbovePleasantTemperature1()
        {
            float edgeAbovePleasantTemp = 21.0f;
            string result = temperatureConverter.TemperatureConverter(edgeAbovePleasantTemp);
            Assert.AreEqual("It's nice today", result);
        }
        [Test]
        public void TestPleasantTemperature()
        {
            float pleasantTemp = 15.0f;
            string result = temperatureConverter.TemperatureConverter(pleasantTemp);
            Assert.AreEqual("It's very pleasant", result);
        }

        [Test]
        public void TestBelowNiceTemperature()
        {
            float belowNiceTemp = 19.0f;
            string result = temperatureConverter.TemperatureConverter(belowNiceTemp);
            Assert.AreEqual("It's very pleasant", result);
        }

        [Test]
        public void TestEdgeCaseBelowPleasantTemperature()
        {
            float edgeBelowPleasantTemp = 10.0f;
            string result = temperatureConverter.TemperatureConverter(edgeBelowPleasantTemp);
            Assert.AreEqual("It's very pleasant", result);
        }

        [Test]
        public void TestColdTemperature()
        {
            float coldTemp = 5.0f;
            string result = temperatureConverter.TemperatureConverter(coldTemp);
            Assert.AreEqual("Better get a coat. It's cold out there!", result);
        }

        [Test]
        public void TestEdgeCaseMinimumTemperature()
        {
            float edgeMinTemp = 0.0f;
            string result = temperatureConverter.TemperatureConverter(edgeMinTemp);
            Assert.AreEqual("Better get a coat. It's cold out there!", result);
        }

        

        [Test]
        public void TestBelowRangeTemperature()
        {
            float belowRangeTemp = -1.0f;
            string result = temperatureConverter.TemperatureConverter(belowRangeTemp);
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void TestAboveRangeTemperature()
        {
            float aboveRangeTemp = 41.0f;
            string result = temperatureConverter.TemperatureConverter(aboveRangeTemp);
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

      

        [Test]
        public void TestEdgeCaseJustAboveColdTemperature()
        {
            float edgeAboveColdTemp = 9.9f;
            string result = temperatureConverter.TemperatureConverter(edgeAboveColdTemp);
            Assert.AreEqual("Better get a coat. It's cold out there!", result);
        }

        [Test]
        public void TestEdgeCaseJustBelowColdTemperature()
        {
            float edgeBelowColdTemp = 10.1f;
            string result = temperatureConverter.TemperatureConverter(edgeBelowColdTemp);
            Assert.AreEqual("It's very pleasant", result);
        }
    }

}