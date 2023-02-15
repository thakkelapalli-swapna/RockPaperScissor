using static RockPaperScissor.Common.Enums;

namespace RockPaperScissor.Interfaces
{
    public interface IGame
    {
        public Result Play(Input player, Input computer);
    }
}
