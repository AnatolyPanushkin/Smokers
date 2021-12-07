using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smokers
{
    public abstract class Smoke
    {
        public virtual Task Smoking(string name = "Undefind")
        {
            ConsoleHelper.WriteToConsole($"{name} курит");
            Thread.Sleep(2000);
            return Task.CompletedTask;
        }
    }
}