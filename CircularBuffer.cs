
namespace PlayingWithGenerics
{
    public class CircularBuffer<T> : Buffer<T>
    {
        private int _capacity;

        public CircularBuffer(int capacity)
        {
            _capacity = capacity;
        }

        public CircularBuffer() : this(capacity: 5)
        {

        }

        public override void Write(T value)
        {
            _queue.Enqueue(value);

            if(_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }

        }

        public override T Read()
        {
            var result = _queue.Dequeue();
            return result;
        }

        public int Capacity { get => _capacity; }

        public bool IsFull { get => _queue.Count == _capacity; }

    }

}