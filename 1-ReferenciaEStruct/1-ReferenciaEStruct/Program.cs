using System;

namespace _1_ReferenciaEStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; // por ser struct não precisa de = new
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}
