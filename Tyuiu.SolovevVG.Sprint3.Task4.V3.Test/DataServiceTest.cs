using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint3.Task4.V3.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            Assert.AreEqual(1.924, res);
        }
    }
}
