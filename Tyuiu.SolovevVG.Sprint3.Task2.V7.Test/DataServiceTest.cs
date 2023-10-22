using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint3.Task2.V7.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = 1, stopValue = 10;
            double res = dataService.GetSumSeries(startValue, stopValue), wait = 77.704;
            Assert.AreEqual(wait, res);
        }
    }
}
