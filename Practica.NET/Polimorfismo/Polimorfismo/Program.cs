using System;
using System.Drawing;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePoly x = new ClasePoly();
            x.Poly(42);
            x.Poly("abcd");
            x.Poly(12.3467891234);
            x.Poly(new Point(23, 45));
            Console.ReadKey();
        }
    }
}
