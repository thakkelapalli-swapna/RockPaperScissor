using RockPaperScissor.Common;
using RockPaperScissor.Interfaces;
using System;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissor.Services
{
    public class Action : IAction
    {
        public int GetDesiredRounds()
        {
            int result;
            do
            {
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine(Constants.InvalidInput);
                }
            } while (true);
        }

        public Input GetPlayerAction()
        {
            Input result;
            do
            {
                var input = Console.ReadLine();
                if (Input.TryParse(input, true, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine(Constants.InvalidAction, input);
                }
            } while (true);
        }
        public Input GetComputerAction()
        {
            Random random = new Random();
            return (Input)random.Next((int)Input.Rock, (int)Input.Scissor + 1);
        }
    }
}
