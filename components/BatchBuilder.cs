using System;

namespace App
{
    public class SecureAdapter
    {
        private int _state;

        public SecureAdapter(int seed) => _state = seed;

        public int parse(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 66) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SecureAdapter(66);
            Console.WriteLine(obj.parse(66));
        }
    }
}
