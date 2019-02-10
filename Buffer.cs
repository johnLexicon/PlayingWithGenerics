using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

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

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in _queue){
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<TOutput> AsEnumerableOf<TOutput>()
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            
            foreach(var item in _queue)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }
    }

}