using System.Collections.Generic;

namespace PlayingWithGenerics
{

    public class Buffer<T> : IBuffer<T>
    {

        private Queue<T> _queue = new Queue<T>();

        public bool IsEmpty => _queue.Count == 0;

        public T Read()
        {
            return _queue.Dequeue();
        }

        public void Write(T value)
        {
            _queue.Enqueue(value);
        }
    }

}