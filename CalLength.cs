using System;

namespace LineCompProb
{
    class CalLength
    {
        public int Point1(int x1, int x2)
        {
            int x = x2 - x1;
            return x;
        }

        public int Point2(int y1, int y2)
        {
            int y = y2 - y1;
            return y;

        }

        public static void Main(string[] args)
        {
            CalLength cl = new CalLength();
            int a = cl.Point1(10, 20);
            int b = cl.Point2(30, 40);
            double result = Math.Sqrt((a ^ 2) + (b ^ 2));
            Console.WriteLine("Result using Cartesian System:" + result);
        }
    }
}
