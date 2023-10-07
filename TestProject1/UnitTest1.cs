namespace TestProject1
{
    public class Tests
    {
        TestObjects to;

        [SetUp]
        public void Setup()
        {
            to = new TestObjects();
        }

        [TearDown]
        public void Clear()
        {
            to = null;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestIsFibonacciMember()
        {
            Assert.IsTrue(to.IsFibonacciMember(1));
            Assert.IsTrue(to.IsFibonacciMember(8));
            Assert.IsTrue(to.IsFibonacciMember(13));
            Assert.True(to.IsFibonacciMember(21));

            Assert.False(to.IsFibonacciMember(4));
            Assert.False(to.IsFibonacciMember(24));
            Assert.False(to.IsFibonacciMember(42));
            Assert.False(to.IsFibonacciMember(65));
        }
    }
}