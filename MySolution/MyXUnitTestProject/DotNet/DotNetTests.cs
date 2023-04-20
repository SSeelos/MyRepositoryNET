using MyClassLibraryNET;

namespace MyXUnitTestProject
{
    public class DotNetTests
    {
        [Fact]
        public void DotNetReferencesTest()
        {
            var dotNet = new DotNet();
            dotNet.Should().NotBeNull();
        }
    }
}
