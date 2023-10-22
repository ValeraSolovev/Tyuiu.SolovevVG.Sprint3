using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SolovevVG.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double powRes = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                powRes += Math.Pow(3 / (i + Math.Pow(value, -i)), 2);
            }
            return Math.Round(powRes, 3);
        }
    }
}