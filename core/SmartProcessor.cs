using System;

namespace App
{
    public class RemoteSession
    {
        private int _state;

        public RemoteSession(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 14) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new RemoteSession(14);
            Console.WriteLine(obj.dispatch(14));
        }
    }
}
