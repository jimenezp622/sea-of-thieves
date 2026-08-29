using System;

namespace App
{
    public class SharedProcessor
    {
        private int _state;

        public SharedProcessor(int seed) => _state = seed;

        public int sync(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 76) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SharedProcessor(76);
            Console.WriteLine(obj.sync(76));
        }
    }
}
