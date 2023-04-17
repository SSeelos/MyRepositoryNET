namespace MyClassLibraryNET.Tests
{
    public class MyClassTests
    {
        [Fact()]
        public void MyClassTest()
        {
            var myObject = new MyClass();
            myObject.Should().NotBeNull();
            myObject.MyInit.Should().Be(nameof(MyClass.MyInit));
        }
        [Fact()]
        public void MyClassInitTest()
        {
            var myObject = new MyClass() { MyInit = nameof(MyClass.MyInit) };
            myObject.Should().NotBeNull();
            myObject.MyInit.Should().Be(nameof(MyClass.MyInit));
        }
        [Fact]
        public void EqualsTest()
        {
            var myClass = new MyClass
            {
                MyInit = nameof(MyClass.MyInit)
            };
            var other = new MyClass
            {
                MyInit = nameof(MyClass.MyInit)
            };

            myClass.Equals(other).Should().BeFalse();
            (myClass == other).Should().BeFalse();
        }
    }
}