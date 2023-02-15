using static RockPaperScissor.Common.Enums;

namespace RockPaperScissor.Interfaces
{
    public interface IAction
    {
        public Input GetPlayerAction(string input);
        public Input GetComputerAction();
    }
}
