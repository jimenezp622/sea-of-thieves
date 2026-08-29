using System;

namespace App
{
    public class HybridProcessor
    {
        private int _state;

        public HybridProcessor(int seed) => _state = seed;

        public int run(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 40) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new HybridProcessor(40);
            Console.WriteLine(obj.run(40));
        }
    }
}
