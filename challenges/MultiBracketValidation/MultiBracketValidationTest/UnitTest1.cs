using MultiBracketValidation;
using System;
using Xunit;

namespace MultiBracketValidationTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}", true)]
        [InlineData("{}[]()", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("{}{Code}[Fellows][({})]", true)]
        [InlineData("(]({})", false)]
        [InlineData("[({}]", false)]
        [InlineData("{(})", false)]
        public void ShouldReturnCorrectBooleanIfBracketsAreValidated(string value, bool expected)
        {
            BracketValidation BV = new BracketValidation();
            bool actual = BV.ValidateBrackets(value);
            Assert.Equal(expected, actual);
        }
    }
}
