using Xunit;
using static RockPaperScissor.Common.Enums;
using RockPaperScissor.Services;

namespace RockPaperScissors.Test
{
    public class GameTest
    {
		private readonly Action _action;
		private readonly Game _game;

        public GameTest()
        {
            _action = new Action();
            _game = new Game();
        }

		/// <summary>
		/// PlayPostiveTest valid input positive test.
		/// </summary>
		[Fact(DisplayName = "PlayPostiveTest : Positive Scenario: Valid input")]
		public void PlayPostiveTest()
		{
			//arrange
			var playerAction = Input.Paper;
			var computerAction = _action.GetComputerAction();
			//Act
			var response = _game.Play(playerAction, computerAction);
			var respnseInt = response == Result.Exception ? 0 : 1;
			//Assert
			Assert.Equal(1, respnseInt);
		}
		/// <summary>
		/// PlayerWinTest valid input positive test.
		/// </summary>
		[Fact(DisplayName = "PlayerWinTest : Player win the game")]
		public void PlayerWinTest()
		{
			//arrange
			var playerAction = Input.Rock;
			var computerAction = Input.Scissor;
			//Act
			var response = _game.Play(playerAction, computerAction);
			//Assert
			Assert.Equal((int)response, (int)Result.PlayerWon);
		}
		/// <summary>
		/// ComputerWinTest valid input positive test.
		/// </summary>
		[Fact(DisplayName = "ComputerWinTest : Computer win the game")]
		public void ComputerWinTest()
		{
			//arrange
			var playerAction = Input.Rock;
			var computerAction = Input.Paper;
			//Act
			var response = _game.Play(playerAction, computerAction);
			//Assert
			Assert.Equal((int)response, (int)Result.ComputerWon);
		}
		/// <summary>
		/// GameTieTest valid input positive test.
		/// </summary>
		[Fact(DisplayName = "GameTieTest : Tie game")]
		public void GameTieTest()
		{
			//arrange
			var playerAction = Input.Scissor;
			var computerAction = Input.Scissor;
			//Act
			var response = _game.Play(playerAction, computerAction);
			//Assert
			Assert.Equal((int)response, (int)Result.Tie);
		}
		/// <summary>
		/// PlayNegativeTest invalid input.
		/// </summary>
		[Fact(DisplayName = "PlayNegativeTest : nagative Scenario: InValid input")]
		public void PlayNegativeTest()
		{
			//arrange
			var playerAction = Input.Invalid;
			var computerAction = _action.GetComputerAction();
			//Act
			var response = _game.Play(playerAction, computerAction);
			var respnseInt = response == Result.Exception ? 0 : 1;
			//Assert
			Assert.Equal(0, respnseInt);
		}
	}
}
