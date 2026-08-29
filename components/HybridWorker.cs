using System;

namespace App
{
    public class SecureParser
    {
        private int _state;

        public SecureParser(int seed) => _state = seed;

        public int render(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 52) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureParser(52);
            Console.WriteLine(obj.render(52));
        }
    }
}
