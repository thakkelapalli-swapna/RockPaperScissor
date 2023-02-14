using RockPaperScissor.Interfaces;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Services
{
    public class Game : IGame
    {
        public Result Play(Input player, Input computer)
        {
            switch (player)
            {
                case Input.Rock:
                    switch (computer)
                    {
                        case Input.Rock: return Result.Tie;
                        case Input.Paper: return Result.ComputerWon;
                        case Input.Scissor: return Result.PlayerWon;
                    }
                    break;
                case Input.Paper:
                    switch (computer)
                    {
                        case Input.Rock: return Result.PlayerWon;
                        case Input.Paper: return Result.Tie;
                        case Input.Scissor: return Result.ComputerWon;
                    }
                    break;
                case Input.Scissor:
                    switch (computer)
                    {
                        case Input.Rock: return Result.ComputerWon;
                        case Input.Paper: return Result.PlayerWon;
                        case Input.Scissor: return Result.Tie;
                    }
                    break;
            }
            // This should never be reached
            return Result.Exception;
        }
    }
}
