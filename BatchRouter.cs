using System;

namespace App
{
    public class SmartHandler
    {
        private int _state;

        public SmartHandler(int seed) => _state = seed;

        public int load(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 97) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SmartHandler(97);
            Console.WriteLine(obj.load(97));
        }
    }
}
