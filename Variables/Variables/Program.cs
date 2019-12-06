using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Args {0} : {1}", i, args[i]);
            }
        }
    }
}
