using System;

namespace Smokers
{
    public class ConsoleHelper
    {
        public static object LockObject = new object();
        public static void WriteToConsole(string info)
        {
            lock(LockObject)
            {
                Console.WriteLine(info);
            }
        }
    }
}