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
        [Fact()]
        public void MyClassMethodsTest()
        {
            var myClass = new MyClass();
            var myMethod = myClass.MyMethod();
            MyClass.MyStaticMethod();

            myClass.MyMethodFromBase();
            myClass.MyAbstractMethod();
            myClass.MyVirtualMethod();

            myClass.MyInterfaceA_Method();
            myClass.MyInterfaceB_Method();
            myClass.MyInterfaceC_Method();

            myClass.MyExtensionMethod();
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