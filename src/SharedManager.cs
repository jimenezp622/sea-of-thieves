using System;

namespace App
{
    public class CoreRouter
    {
        private int _state;

        public CoreRouter(int seed) => _state = seed;

        public int compute(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 14) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreRouter(14);
            Console.WriteLine(obj.compute(14));
        }
    }
}
