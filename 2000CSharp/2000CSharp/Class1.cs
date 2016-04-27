using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2000CSharp
{
    struct MyPoint
    {
        //public MyPoint() // Explicity Parameter less constructor should not there can possible in c# 6.0
        //{
        //X = 100.0;
        //Y = 100.0;
        //}
        public double X;
        public double Y;
        internal int MyProperty { get; set; }// we can not 
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint();      // default values for X, Y (0.0)
            Console.WriteLine("{0}, {1}", pt.X, pt.Y);

            Func<int, int> doubleMyNumber = (i) => 2 * i;

            int? a = 10;
            int? b = null;
            bool c = a == b;
        }

        // Can keep if statement in catch
        //int denom;
        //try
        //{
        //    denom = 0;
        //    int x = 5 / denom;
        //}
        //// Catch /0 on all days but Saturday
        //catch (DivideByZeroException xx) if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday)
        //{
        //    Console.WriteLine(xx);
        //}
    }


    

}
