using System;

namespace LineCompProb
{
    class EqOfTwoLines
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

        public int Point3(int p1, int p2)
        {

            int p = p2 - p1;
            return p;
        }

        public int Point4(int q1, int q2)
        {
            int q = q2 - q1;
            return q;
        }
        public static void Main(string[] args)
        {
            EqOfTwoLines cl = new EqOfTwoLines();
            int a = cl.Point1(10, 30);
            int b = cl.Point2(30, 40);
            int c = cl.Point3(50, 60);
            int d = cl.Point4(70, 80);
            double result1 = Math.Sqrt((a ^ 2) + (b ^ 2));
            Console.WriteLine("First Line Length using Cartesian System:" + result1);
            double result2 = Math.Sqrt((c ^ 2) + (d ^ 2));
            Console.WriteLine("Second Line Length using Cartesian System:" + result2);

            if (result1 == result2)
            {
                Console.WriteLine("Both Line Are Equal ");
            }
            else
            {
                Console.WriteLine(" BOth Lines Are Not Equal ");
            }
        }
    }
}
