using System.Threading.Tasks;

namespace Smokers
{
    public class SmokerWithTabacco:Smoke
    {
        private string _name = "Smoker ith tabacco";
        public override Task Smoking(string name = "Undefind")
        {
            return base.Smoking(_name);
        }
    }
}