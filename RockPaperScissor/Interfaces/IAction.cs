using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Interfaces
{
    public interface IAction
    {
        public Input GetPlayerAction(string input);
        public Input GetComputerAction();
    }
}
