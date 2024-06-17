using NUnit.Framework;

public class MathTests
{
    private int _initialValue;

    [SetUp]
    public void Setup()
    {
        // ตั้งค่าเริ่มต้นก่อนการทดสอบแต่ละครั้ง
        _initialValue = 10;
    }

    [Test]
    public void AdditionTest()
    {
        int result = Add(_initialValue, 5);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void SubtractionTest()
    {
        int result = Subtract(_initialValue, 5);
        Assert.AreEqual(5, result);
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
