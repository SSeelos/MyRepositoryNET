namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class MyImmutableClassTests
    {
        [Fact()]
        public void MyImmutableClassTest()
        {
            var instance = new MyImmutableClass("myValue");
            instance.MyImmutableProperty.Should().Be("myValue");
        }

        [Fact()]
        public void MyImmutableClassTest1()
        {
            var instance = new MyImmutableClass("myValue", "myValue2");
            instance.MyImmutableProperty.Should().Be("myValue");
            instance.MyGetOnlyAutoProperty.Should().Be("myValue2");
        }
    }
}