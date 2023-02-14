﻿using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static RockPaperScissor.Enums.Enums;
namespace RockPaperScissors.Test
{
    public class PlayTest
    {
        public PlayTest()
        { }         /// <summary>
                            /// GetPlayerAction valid input positive test.
                            /// </summary>
        [Fact(DisplayName = "GetPlayerActionPostive : Positive Scenario: Valid input")]
        public void GetPlayerActionPostive()
        {
            var _action = new RockPaperScissor.Services.Action();
            var _game = new RockPaperScissor.Services.Game();
            var playerAction = Input.Paper;
            var computerAction = _action.GetComputerAction();
            var response = _game.Play(playerAction, computerAction);
            var respnseInt = response == Result.Exception ? 0 : 1;
            Assert.Equal(1, respnseInt);
        }
    }
}