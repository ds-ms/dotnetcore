using Xunit;

namespace PrimeChecker.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class Class1
    {
        [Fact]
        public void TwoIsPrime()
        {
            Assert.Equal(true, PrimeChecker.Prime.IsPrime(2));
        }
    }
}
