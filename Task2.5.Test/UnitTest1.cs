namespace Task2._5.Test
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
            Assert.That(calculator.Division(25,5) == 5);
        }
    }
}