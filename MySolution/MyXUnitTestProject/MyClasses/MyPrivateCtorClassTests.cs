namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class MyPrivateCtorClassTests
    {
        [Fact()]
        public void CreateTest()
        {
            var instance = MyPrivateCtorClass.Create();
            instance.Should().NotBeNull();
        }
    }
}