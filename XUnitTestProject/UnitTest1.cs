using Xunit;

public class MathTests
{
    [Fact]
    public void AdditionTest()
    {
        int result = Add(2, 3);
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(10, 5, 5)]
    [InlineData(0, 0, 0)]

    public void SubtractionTest(int a, int b, int expected)
    {
        int result = Subtract(a, b);
        Assert.Equal(expected, result);
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(3, 5, 8)]
    [InlineData(-1, -1, -2)]
    
    public void AdditionTheoryTest(int a, int b, int expected)
    {
        int result = Add(a, b);
        Assert.Equal(expected, result);
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}
