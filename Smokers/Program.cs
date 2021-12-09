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
        private static Mutex _allWait = new Mutex();
        static void Main(string[] args)
        {
            Thread thread;
            thread= new Thread(Servant);
            thread.Start();
            thread.Join();
            
            
            
            

        }

        static async void Servant()
        {
            int v1 = new Random().Next(1, 4);
            int v2 = new Random().Next(1, 4);
            //1 - бумага
            //2 - спички
            //3 - табак

            await Tabacco(v1, v2);
            await Paper(v1, v2);
            await Matches(v1, v2);
            
            Servant();
        }

        static async Task Tabacco(int v1,int v2)
        {
            if ((v1==1 & v2==2) || (v1==2 & v2==1 ))
            {
                _allWait.WaitOne();
                ConsoleHelper.WriteToConsole("Курильщик с табаком курит");
                Thread.Sleep(2000);
                _allWait.ReleaseMutex(); 
            }
        }
        
        static async Task Matches(int v1,int v2)
        {
            if ((v1 == 1 & v2 == 3) || (v1 == 3 & v2 == 1))
            {
                _allWait.WaitOne();
                ConsoleHelper.WriteToConsole("Курильщик со спичками курит");
                Thread.Sleep(2000);
                _allWait.ReleaseMutex();
            }
        }

        static async Task Paper(int v1,int v2)
        {
            if ((v1 == 2 & v2 == 3) || (v1 == 3 & v2 == 2))
            {
                _allWait.WaitOne();
                ConsoleHelper.WriteToConsole("Курильщик с бумагой курит");
                Thread.Sleep(2000);
                _allWait.ReleaseMutex();
            }
        }
        
    }

}