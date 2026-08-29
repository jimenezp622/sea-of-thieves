using System;

namespace App
{
    public class SmartProcessor
    {
        private int _state;

        public SmartProcessor(int seed) => _state = seed;

        public int parse(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 76) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SmartProcessor(76);
            Console.WriteLine(obj.parse(76));
        }
    }
}
