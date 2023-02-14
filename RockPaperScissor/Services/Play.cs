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
            int playerPoints = 0;
            int computerPoints = 0;
            Console.WriteLine(Constants.WelcomeMessage);
            Console.WriteLine(Constants.EnterName);
            string name = Console.ReadLine();
            Console.WriteLine(Constants.GreetingMsg, name);
            Console.ReadLine();
            //int rounds = _action.GetDesiredRounds();
            PlayRounds();
            //Console.WriteLine(Constants.Result, playerPoints, computerPoints);
            //if (playerPoints == computerPoints)
            //{
            //    Console.WriteLine(Constants.TieGame);
            //}
            //else
            //{
            //    string message = playerPoints > computerPoints ? string.Format(Constants.UserWinsTheGame, name) : string.Format(Constants.ComputerWinsTheGame, name);
            //    Console.WriteLine(message);
            //}
        }
        private void PlayRounds()
        {
            string repeat = string.Empty;
            do
            {
                //Console.WriteLine(Constants.BeginMsg, rounds);
                Console.WriteLine(Constants.UserInputMsg);

                var playerAction = _action.GetPlayerAction();
                Console.WriteLine(Constants.UserChoice, playerAction.ToString());

                var computerAction = _action.GetComputerAction();
                Console.WriteLine(Constants.ComputerChoise, computerAction.ToString());

                switch (_game.Play(playerAction, computerAction))
                {
                    case Result.PlayerWon:
                        Console.WriteLine(Constants.UserWinsRound);
                        //playerPoints++;
                        break;
                    case Result.ComputerWon:
                        Console.WriteLine(Constants.ComputerWinsRound);
                        //computerPoints++;
                        break;
                    case Result.Tie:
                        Console.WriteLine(Constants.TieRound);
                        //playerPoints++;
                        //computerPoints++;
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
