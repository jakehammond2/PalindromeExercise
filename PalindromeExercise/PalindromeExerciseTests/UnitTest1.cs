using System;
using Xunit;
using PalindromeExercise; 


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dad", true)]
        [InlineData("Hannah", true)]
        [InlineData("Levels",false)]

        public void Test1(string word, bool expected)
        {

            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word); 

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
