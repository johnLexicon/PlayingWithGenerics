
namespace PlayingWithGenerics
{
    public class CircularBuffer<T> : IBuffer<T>
    {

        private readonly T[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer(int capacity)
        {
            _start = 0;
            _end = 0;
            _buffer = new T[capacity + 1];
        }

        public CircularBuffer() : this(capacity: 5)
        {

        }

        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;

            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }

        public T Read()
        {
            var result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }

        public int Capacity { get => _buffer.Length; }

        public bool IsEmpty { get => _end == _start; }

        public bool IsFull { get => (_end + 1) % _buffer.Length == _start; }

    }

}