using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Interfaces
{
    public interface IAction
    {
        public int GetDesiredRounds();
        public Input GetPlayerAction();
        public Input GetComputerAction();
    }
}
