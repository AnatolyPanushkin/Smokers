using System.Threading.Tasks;

namespace Smokers
{
    public class SmokersWithPaper:Smoke
    {
        private string _name = "Smoker with paper";
        public override Task Smoking(string name = "Undefind")
        {
            return base.Smoking(_name);
        }
    }
}