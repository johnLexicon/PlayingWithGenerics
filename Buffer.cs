using System.Collections.Generic;

namespace PlayingWithGenerics
{

    public class Buffer<T> : IBuffer<T>
    {

        protected Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpty => _queue.Count == 0;

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }
    }

}