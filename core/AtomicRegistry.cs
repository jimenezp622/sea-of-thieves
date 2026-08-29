using System;

namespace App
{
    public class SmartResolver
    {
        private int _state;

        public SmartResolver(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 43) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SmartResolver(43);
            Console.WriteLine(obj.parse(43));
        }
    }
}
