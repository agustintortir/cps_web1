using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enumeracion
{
    class Program
    {
    enum State{Off, On}

    enum Color
        {
            red = 1,
            green = 2,
            blue = 4,
            black = 0,
            white = red | green | blue
        }

        static void Main(string[] args)
        {
            Color c = Color.black;
            Console.WriteLine((int)c);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c);
            Console.ReadKey();

            Color x = Color.white;
            Console.WriteLine((int)x);
            Console.WriteLine(x.ToString());
            Console.ReadKey();

            State y = State.On;
            Console.WriteLine((int)y);
            Console.WriteLine(y.ToString());
            Console.ReadKey();
        }
    }
}
