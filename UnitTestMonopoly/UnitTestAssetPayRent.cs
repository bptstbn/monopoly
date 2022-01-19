using System;
using Xunit;
using monopoly;

namespace UnitTestMonopoly
{
    public class UnitTestAssetPayRent
    {
        [Fact]
        public void Test1()
        {
            // player1 lands on player2's property and must pay a rent
            Game game = new Game();
            Player player1 = new Player("John");
            game.Players.Add(player1);
            player1.Money = 500;
            Player player2 = new Player("Charles");
            game.Players.Add(player2);
            player2.Money = 900;
            Dice dice = new Dice();
            Asset boardwalk = (Asset)game.Board.Array[39];
            boardwalk.owner = player1;
            player1.Assets.Add(boardwalk);
            boardwalk.PayRent(player2, dice, game);
            Assert.Equal(550, player1.Money);
            Assert.Equal(850, player2.Money);
        }
    }
}
