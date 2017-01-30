using NUnit.Framework;
using HelloWorld;

namespace HelloWorldUnitTest2
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.IsDataContainsKeyword("Hello Unit Tester", "NO"));
        }
    }
}
