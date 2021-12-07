using System.Threading.Tasks;

namespace Smokers
{
    public class SmokerWithMatches:Smoke
    {
        private string _name = "Smoker with matches";
        public override Task Smoking(string name = "Undefind")
        {
            return base.Smoking(_name);
        }
    }
}