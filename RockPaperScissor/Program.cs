using RockPaperScissor.Interfaces;
using RockPaperScissor.Services;
using System;

namespace RockPaperScissor
{
    /// <summary>
    /// Main programe class
    /// </summary>
    public static class Program
    {
        static void Main(string[] args)
        {
            IAction action = new Services.Action();
            IGame game = new Game();
            IPlay play = new Play(action, game);
            play.PlayGame();
        }
    }
}


