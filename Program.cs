using System;

namespace PlayingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuffer<double> cb = new Buffer<double>();
            System.Console.WriteLine(cb.IsEmpty);
            cb.Write(1);
            cb.Write(2);
            cb.Write(3);
            cb.Write(4);
            cb.Write(5);
            cb.Write(6);
            //Console.WriteLine(cb.IsFull);

            System.Console.WriteLine(cb.Read());
            System.Console.WriteLine(cb.Read());
            System.Console.WriteLine(cb.Read());
        }
    }
}
