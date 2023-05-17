namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class MyGenericClassTests
    {
        [Fact()]
        public void MyGenericClassTest()
        {
            var instance = new MyGenericClass<string>("myValue");
            instance.MyValue.Should().Be("myValue");
        }
    }
}