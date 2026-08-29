using System;

namespace App
{
    public class StreamFactory
    {
        private int _state;

        public StreamFactory(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 69) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new StreamFactory(69);
            Console.WriteLine(obj.decode(69));
        }
    }
}
