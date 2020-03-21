using Xunit;
using ArrayShift;

public class Test
{
    [Fact]

    public void TestWiredUp()
    {
        Assert.True(true);
    }

    [Fact]
    public void TestOddSize()
    {
        int[] array = { 2, 4, 6, 8, 10 };
        int number = 5;
        string actual = Program.Shift(array, number);
        string expected = "Array: { 2, 4, 5, 6, 8, 10, }";
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestEvenSize()
    {
        int[] array = { 2, 4, 6, 8 };
        int number = 5;
        string actual = Program.Shift(array, number);
        string expected = "Array: { 2, 4, 5, 6, 8, }";
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestOneElementInArray()
    {
        int[] array = { 2 };
        int number = 3;
        string actual = Program.Shift(array, number);
        string expected = "Array: { 2, 3 }";
        Assert.Equal(actual, expected);
    }
    

}
