
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlayingWithGenerics
{

    public static class BufferExtensions
    {

        public static IEnumerable<TOutput> Map<TOutput, T>(this IBuffer<T> buffer, Converter<T, TOutput> convert)
        {
            foreach(var item in buffer)
            {
                TOutput result = convert(item);
                yield return result;
            }
        }

        public static void Dump<T>(this Buffer<T> buffer, Action<T> printer)
        {
            foreach(var item in buffer)
            {
                printer(item);
            }
        }
    }


}