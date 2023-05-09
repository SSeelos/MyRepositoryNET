namespace MyRootNamespace.MyClassLibraryNET.Tests
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
