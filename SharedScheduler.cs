using System;

namespace App
{
    public class RemoteFactory
    {
        private int _state;

        public RemoteFactory(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 94) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new RemoteFactory(94);
            Console.WriteLine(obj.run(94));
        }
    }
}
