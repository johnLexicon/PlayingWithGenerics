using System;
using System.Linq;

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
            
            Converter<double, DateTime> convert = v => new DateTime().AddDays(v); 
            var asDates = cb.Map<DateTime, double>(convert);
            asDates.ToList().ForEach(v => System.Console.WriteLine(v));

            //Action is a default delegate type that can take up to 16 parameters and returns void.
            Action<double> print = d => System.Console.WriteLine(d);
            cb.Dump(print);

        }
    }
}
