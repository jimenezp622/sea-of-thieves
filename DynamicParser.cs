using System;

namespace App
{
    public class AtomicProvider
    {
        private int _state;

        public AtomicProvider(int seed) => _state = seed;

        public int decode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 76) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicProvider(76);
            Console.WriteLine(obj.decode(76));
        }
    }
}
