using System;

namespace App
{
    public class SimpleDispatcher
    {
        private int _state;

        public SimpleDispatcher(int seed) => _state = seed;

        public int build(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 4) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleDispatcher(4);
            Console.WriteLine(obj.build(4));
        }
    }
}
