using System;

namespace App
{
    public class AsyncBuilder
    {
        private int _state;

        public AsyncBuilder(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 50) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AsyncBuilder(50);
            Console.WriteLine(obj.decode(50));
        }
    }
}
