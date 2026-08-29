using System;

namespace App
{
    public class StreamClient
    {
        private int _state;

        public StreamClient(int seed) => _state = seed;

        public int render(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 11) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamClient(11);
            Console.WriteLine(obj.render(11));
        }
    }
}
