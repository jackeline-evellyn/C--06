using System;

namespace _2_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");


            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");


            //Operador de colescência nula

            double a = x ?? 5;
            Console.WriteLine(a);
        }
    }
}
