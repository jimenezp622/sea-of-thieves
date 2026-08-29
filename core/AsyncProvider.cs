using System;

namespace App
{
    public class SimpleManager
    {
        private int _state;

        public SimpleManager(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 23) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleManager(23);
            Console.WriteLine(obj.load(23));
        }
    }
}
