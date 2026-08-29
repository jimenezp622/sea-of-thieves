using System;

namespace App
{
    public class SmartBuffer
    {
        private int _state;

        public SmartBuffer(int seed) => _state = seed;

        public int collect(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 82) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SmartBuffer(82);
            Console.WriteLine(obj.collect(82));
        }
    }
}
