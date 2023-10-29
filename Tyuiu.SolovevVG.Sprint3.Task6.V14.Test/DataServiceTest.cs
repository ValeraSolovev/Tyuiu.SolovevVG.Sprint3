using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint3.Task6.V14.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = 7, stopValue = 16, res = dataService.GetSumTheDivisors(startValue, stopValue), wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
