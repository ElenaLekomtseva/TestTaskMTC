using System;

namespace ElenaLekomtsevaTestTaskMTC
{
    public static class ClassM
    {
        public static double Sqrt(double inValue)
        {
            if (inValue < 0)
                throw new ArgumentOutOfRangeException("Невозможно извлечь квадратный корень из отрицательного числа");

            return Math.Sqrt(inValue);
        }
    }
}
