using System;
using Xunit;
using monopoly;

namespace UnitTestMonopoly
{
    public class UnitTestMoveForward
    {
        [Fact]
        public void Test1()
        {
            // Player is free and collects 200$ while passing by Go
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            player1.Money = 500;
            player1.Position = 35;
            dice.DieA = 5;
            dice.DieB = 6;
            player1.MoveForward(dice);
            Assert.Equal(6, player1.Position);
            Assert.Equal(700, player1.Money);
        }
        [Fact]
        public void Test2()
        {
            // Player is in jail and stays there
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            player1.Free = false;
            player1.Position = 10;
            player1.CountTurnJail = 1;
            dice.DieA = 5;
            dice.DieB = 6;
            player1.MoveForward(dice);
            Assert.Equal(10, player1.Position);
            Assert.True(!player1.Free);
        }
        [Fact]
        public void Test3()
        {
            // Player is in jail and rolls a double
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            player1.Free = false;
            player1.Position = 10;
            player1.CountTurnJail = 1;
            dice.DieA = 3;
            dice.DieB = 3;
            player1.MoveForward(dice);
            Assert.Equal(16, player1.Position);
            Assert.True(player1.Free);
        }
        [Fact]
        public void Test4()
        {
            // Player has been in jail for three turns
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            player1.Free = false;
            player1.Position = 10;
            player1.CountTurnJail = 3;
            dice.DieA = 5;
            dice.DieB = 3;
            player1.MoveForward(dice);
            Assert.Equal(18, player1.Position);
            Assert.True(player1.Free);
        }
    }
}
