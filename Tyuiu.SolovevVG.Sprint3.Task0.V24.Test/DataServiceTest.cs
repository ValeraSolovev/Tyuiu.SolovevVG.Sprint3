using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint3.Task0.V24.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 5;
            int startValue = 1, stopValue = 7;
            double res = dataService.GetMultiplySeries(value, startValue, stopValue), wait = 10.763;
            Assert.AreEqual(wait, res);
        }
    }
}
