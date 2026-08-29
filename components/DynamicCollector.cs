using System;

namespace App
{
    public class SecureGateway
    {
        private int _state;

        public SecureGateway(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 89) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SecureGateway(89);
            Console.WriteLine(obj.handle(89));
        }
    }
}
