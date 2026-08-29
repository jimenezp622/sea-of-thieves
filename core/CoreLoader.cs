using System;

namespace App
{
    public class BatchCollector
    {
        private int _state;

        public BatchCollector(int seed) => _state = seed;

        public int collect(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 61) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new BatchCollector(61);
            Console.WriteLine(obj.collect(61));
        }
    }
}
