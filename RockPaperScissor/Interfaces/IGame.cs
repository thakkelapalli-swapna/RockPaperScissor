using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Interfaces
{
    public interface IGame
    {
        public Result Play(Input player, Input computer);
    }
}
