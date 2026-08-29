using System;

namespace App
{
    public class CoreCache
    {
        private int _state;

        public CoreCache(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 85) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new CoreCache(85);
            Console.WriteLine(obj.dispatch(85));
        }
    }
}
