using System;
using Xunit;

namespace RecursiveOperations.Tests
{
    public class ProgramsTests
    {
        [Fact]
        public void ReturnsNAWhenThereAreNoCombinations()
        {
            Assert.Equal("N/A", Program.GetOperationCombinationsToGivenResult(3, 3));
        }
        
        [Fact]
        public void ReturnsCorrectResultWhenIsOneCombination()
        {
            string result = "1 - 2 + 3 - 4 + 5 = 3\n";
            Assert.Equal(result, Program.GetOperationCombinationsToGivenResult(5, 3));
        }

        [Fact]
        public void ReturnsCorrectResultWhenAreMoreCOmbinations()
        {
            string result = "1 + 2 + 3 - 4 - 5 + 6 = 3\n" +
                "1 + 2 - 3 + 4 + 5 - 6 = 3\n" +
                "1 - 2 - 3 - 4 + 5 + 6 = 3\n";
            Assert.Equal(result, Program.GetOperationCombinationsToGivenResult(6, 3));
                ;
        }
    }
}
