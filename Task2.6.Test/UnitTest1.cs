namespace Task2._6.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException> (() => calculator.Division(10, 0));
        }
    }
}