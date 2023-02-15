using Xunit;
using static RockPaperScissor.Enums.Enums;

namespace RockPaperScissors.Test
{
	public class ActionTest
    {
		private readonly RockPaperScissor.Services.Action _action;

        public ActionTest()
        {
            _action = new RockPaperScissor.Services.Action();
        }

		/// <summary>
		/// GetPlayerActionValidInput valid input negative test.
		/// </summary>
		[Fact(DisplayName = "GetPlayerActionValidInput: valid input")]
		public void GetPlayerActionValidInput()
		{
			var input = "Paper";
			var actionResponse = _action.GetPlayerAction(input);
			Assert.Equal(input, actionResponse.ToString());
		}
		/// <summary>
		/// GetPlayerActionInvalidInput valid input negative test.
		/// </summary>
		[Fact(DisplayName = "GetPlayerActionInvalidInput: Invalid input")]
		public void GetPlayerActionInvalidInput()
		{
			var invalidInp = "SS";
			var actionResponse = _action.GetPlayerAction(invalidInp);
			var respnseInt = actionResponse == Input.Invalid ? 0 : 1;
			Assert.NotEqual(1, respnseInt);
		}
	}
}
