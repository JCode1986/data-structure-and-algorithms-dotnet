using RepeatedWord.Classes;
using System;
using Xunit;

namespace XUnitTestRepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void WorksAsExpected()
        {
            string sentence = "Once upon a time, there was a brave princess who...";
            MyRepeatedWord RW = new MyRepeatedWord();
            string actual = RW.MyWord(sentence);
            Assert.Equal("a", actual);
        }
    }
}
