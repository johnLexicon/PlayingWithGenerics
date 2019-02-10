using System;

namespace PlayingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CircularBuffer<double>();
            System.Console.WriteLine(cb.IsEmpty);
            cb.Write(1.4);
            cb.Write(2.6);
            cb.Write(3.2);
            cb.Write(4);
            cb.Write(5);
            
            var asInts = cb.AsEnumerableOf<int>();
            foreach(var item in asInts)
            {
                System.Console.WriteLine(item);
            }

            // System.Console.WriteLine(cb.Read());
            // System.Console.WriteLine(cb.Read());
            // System.Console.WriteLine(cb.Read());
        }
    }
}
