using System;
using Xunit;
using monopoly;

namespace UnitTestMonopoly
{
    public class UnitTestUtilityRent
    {
        [Fact]
        public void Test1()
        {
            // Player only owns one utility
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            dice.DieA = 4;
            dice.DieB = 3;
            Asset electricCompany = (Asset)game.Board.Array[12];
            electricCompany.owner = player1;
            player1.Assets.Add(electricCompany);
            double rent = electricCompany.Rent(dice);
            Assert.Equal(28, rent);
        }
        [Fact]
        public void Test2()
        {
            // Player owns both utilities
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            Dice dice = new Dice();
            dice.DieA = 5;
            dice.DieB = 4;
            Asset electricCompany = (Asset)game.Board.Array[12];
            electricCompany.owner = player1;
            Asset waterWorks = (Asset)game.Board.Array[28];
            player1.Assets.Add(electricCompany);
            player1.Assets.Add(waterWorks);
            double rent = electricCompany.Rent(dice);
            Assert.Equal(90, rent);
        }
    }
}
