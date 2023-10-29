using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.SolovevVG.Sprint3.Task4.V3.Lib
{
    public class DataService : ISprint3Task4V3
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    y += (Math.Cos(x) + Math.Sin(x)) / x;
                }
                else continue;
            }

            return Math.Round(y, 3);

        }
    }
}
