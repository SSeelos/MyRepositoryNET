using Xunit;

namespace MyLibraryTargetframeworks.Tests
{
    public class Tests
    {
        [Fact()]
        public void GetTargetFrameworkTest()
        {
            var res = FrameworkTest.GetTargetFramework();
#if NETSTANDARD2_1
            Assert.Equal("NETSTANDARD2_1", res);
#endif
#if NET48_OR_GREATER
            Assert.Equal("NET48_OR_GREATER", res);
#endif
        }
    }
}