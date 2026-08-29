using System;

namespace App
{
    public class LocalDispatcher
    {
        private int _state;

        public LocalDispatcher(int seed) => _state = seed;

        public int build(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 29) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LocalDispatcher(29);
            Console.WriteLine(obj.build(29));
        }
    }
}
