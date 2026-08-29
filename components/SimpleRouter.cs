using System;

namespace App
{
    public class SharedRouter
    {
        private int _state;

        public SharedRouter(int seed) => _state = seed;

        public int fetch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 13) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedRouter(13);
            Console.WriteLine(obj.fetch(13));
        }
    }
}
