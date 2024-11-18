using Cart.Infrastructure.Repositories;

namespace Infrastructure.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var tester = new TestClass();

            var expectedValue = "Hello";
            var actualValue = tester.Echo(expectedValue);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}