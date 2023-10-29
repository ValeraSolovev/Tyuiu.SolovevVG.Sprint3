using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint3.Task7.V7.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = -5, stopValue = 5;
            double[] WaitRes = new double[stopValue - startValue + 1];
            WaitRes[0] = 15.19;
            WaitRes[1] = 11.67;
            WaitRes[2] = 9.00;
            WaitRes[3] = 0.00;
            WaitRes[4] = 4.08;
            WaitRes[5] = 1.50;
            WaitRes[6] = -2.28;
            WaitRes[7] = -6.52;
            WaitRes[8] = -10.19;
            WaitRes[9] = -12.76;
            WaitRes[10] = -14.68;
            double[] res = new double[stopValue - startValue + 1];
            res = dataService.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, WaitRes);
        }
    }
}
