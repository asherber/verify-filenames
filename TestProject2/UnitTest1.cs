using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyTests;
using VerifyXunit;
using Xunit;

namespace TestProject2
{
    [UsesVerify]
    public class UnitTest1
    {
        [Theory]
        [MemberData(nameof(Data))]
        public Task Test1(string input)
        {
            return Verifier.Verify(input);
        }

        public static IEnumerable<object[]> Data => new[] { new[] { "Alice" }, new[] { "Bob" } };
    }
}