using RockPaperScissor.Common;
using RockPaperScissor.Interfaces;
using System;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Services
{
    public class Play:IPlay
    {
        private readonly IAction _action;
        private readonly IGame _game;

        public Play(IAction action, IGame game)
        {
            _action = action;
            _game = game;
        }

        public void PlayGame()
        {

            Console.WriteLine(Constants.WelcomeMessage);
            Console.WriteLine(Constants.EnterName);
            string name = Console.ReadLine();
            Console.WriteLine(Constants.GreetingMsg, name);
            Console.ReadLine();

            PlayRounds();

        }
        private void PlayRounds()
        {
            string repeat = string.Empty;
            do
            {

                Console.WriteLine(Constants.UserInputMsg);
                Input playerAction;

				while (true)
				{
                    var input = Console.ReadLine();
                    playerAction = _action.GetPlayerAction(input);
                    if (playerAction != Input.Invalid)
                        break;
                }

                Console.WriteLine(Constants.UserChoice, playerAction.ToString());

                var computerAction = _action.GetComputerAction();
                Console.WriteLine(Constants.ComputerChoise, computerAction.ToString());

                switch (_game.Play(playerAction, computerAction))
                {
                    case Result.PlayerWon:
                        Console.WriteLine(Constants.UserWinsRound);
                        break;
                    case Result.ComputerWon:
                        Console.WriteLine(Constants.ComputerWinsRound);
                        break;
                    case Result.Tie:
                        Console.WriteLine(Constants.TieRound);
                        break;
                    case Result.Exception:
                        Console.WriteLine(Constants.ExceptionMsg);
                        break;
                }
                Console.WriteLine("do you want to play again? Y / N");
                repeat = Console.ReadLine().ToUpper();
            } while (repeat == "Y");
        }
    }
}
