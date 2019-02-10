
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlayingWithGenerics
{

    public static class BufferExtensions
    {

        public delegate void Printer<T>(T data);

        public static IEnumerable<TOutput> AsEnumerableOf<TOutput, T>(this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            
            foreach(var item in buffer)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }

        public static void Dump<T>(this Buffer<T> buffer, Printer<T> printer)
        {
            foreach(var item in buffer)
            {
                printer(item);
            }
        }
    }


}