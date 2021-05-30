using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzTest
{
    public class GameTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void DivideByThre(int number)
        {
            var result = Game.PlayNumber(number);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void DivideByFive(int number)
        {
            var result = Game.PlayNumber(number);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        public void DivideByThreeFive(int number)
        {
            var result = Game.PlayNumber(number);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void OtherNumber()
        {
            var result = Game.PlayNumber(1);
            Assert.Equal("1", result);
        }
    }
}
