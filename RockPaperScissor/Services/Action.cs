using RockPaperScissor.Common;
using RockPaperScissor.Interfaces;
using System;
using static RockPaperScissor.Common.Enums;

namespace RockPaperScissor.Services
{
	public class Action : IAction
	{

		public Input GetPlayerAction(string input)
		{
			Input result;

			if (Input.TryParse(input, true, out result))
			{
				return result;
			}
			else
			{
				Console.WriteLine(Constants.InvalidAction, input);
				return Input.Invalid;
			}

		}
		public Input GetComputerAction()
		{
			Random random = new Random();
			return (Input)random.Next((int)Input.Rock, (int)Input.Scissor + 1);
		}
	}
}
