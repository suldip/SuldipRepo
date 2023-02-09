using System;
using Xunit;

namespace TicTacToeDemo.Tests
{
    public class TicTacToeTests
    {
        [Fact]
        public void Test_A()
        {
            TicTacToeDemo test = new TicTacToeDemo();
            var count = test.PlacePiece(2, 2, 2);
        }
    }
}