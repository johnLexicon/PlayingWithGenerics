
using System.Collections.Generic;

namespace PlayingWithGenerics
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }

        void Write(T value);

        T Read();

    }

}