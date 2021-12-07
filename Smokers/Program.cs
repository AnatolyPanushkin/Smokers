using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smokers
{
    
    class Program
    {
        private static Mutex _tabaccoMutex = new Mutex();
        private static Mutex _matchesMutex = new Mutex();
        private static Mutex _paperMutex = new Mutex();
        static void Main(string[] args)
        {
            Thread thread;
            thread = new Thread(Servant);
            thread.Start();
            thread.Join();

        }

        static async void Servant()
        {
            int v1 = new Random().Next(0, 3);
            int v2 = new Random().Next(0, 3);
            if (v1 == 0 & v2 == 1)
            {
                await Paper();
            }

            if (v1 == 1 & v2 == 2)
            {
                await Tabacco();
            }

            if (v1 == 0 & v2 == 2)
            {
                await Matches();
            }
            else
            {
                Servant();
            }

            Servant();
        }

        static Task Tabacco()
        {
            //_tabaccoMutex.WaitOne();
            ConsoleHelper.WriteToConsole("Курильщик с табаком курит");
            Thread.Sleep(2000);
           // _tabaccoMutex.ReleaseMutex();
            return Task.CompletedTask;
        }
        
        static Task Matches()
        {
           // _matchesMutex.WaitOne();
            ConsoleHelper.WriteToConsole("Курильщик со спичками курит");
            Thread.Sleep(2000);
            //_matchesMutex.ReleaseMutex();
            return Task.CompletedTask;
        }

        static Task Paper()
        {
           // _paperMutex.WaitOne();
            ConsoleHelper.WriteToConsole("Курильщик с бумагой курит");
            Thread.Sleep(2000);
            //_paperMutex.ReleaseMutex();
            return Task.CompletedTask;
        }
        
    }

}