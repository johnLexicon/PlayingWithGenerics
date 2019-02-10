using System;

namespace PlayingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffer<double> cb = new CircularBuffer<double>();
            System.Console.WriteLine(cb.IsEmpty);
            cb.Write(1.4);
            cb.Write(2.6);
            cb.Write(3.2);
            cb.Write(4);
            cb.Write(5);
            
            var asInts = cb.AsEnumerableOf<int, double>();
            cb.Dump(new BufferExtensions.Printer<double>(ConsoleWriter));

        }

        public static void ConsoleWriter(double item)
        {
            Console.WriteLine(item);
        }
    }
}
