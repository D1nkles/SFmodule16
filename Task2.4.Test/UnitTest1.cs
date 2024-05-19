namespace Task2._4.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(143, 73) == 70);
        }
    }
}