namespace MyClassLibraryNET.Tests
{
    public class MyClassTests
    {
        [Fact()]
        public void MyClassTest()
        {
            var myClass = new MyClass();

            myClass.Should().NotBeNull();
        }
    }
}