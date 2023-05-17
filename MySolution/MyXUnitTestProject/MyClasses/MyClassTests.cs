using System.Reflection;

namespace MyRootNamespace.MyClassLibraryNET.Tests
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
        public void MyClassNewTest()
        {
            MyClass myObject = MyClass.New("init");
            myObject.Should().NotBeNull();
            myObject.MyInit.Should().Be("init");
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

        [Fact]
        public void ActionEventTest()
        {
            Action myAction = () => { };
            MyClass.MyStaticEventAction += myAction;

            Action invoke = MyClass.InvokeStaticAction;
            invoke.Should().NotThrow();
        }
        [Fact]
        public void FuncEventTest()
        {
            Func<string> myFunc = () => "return value";
            MyClass.MyStaticEventFunc += myFunc;

            Func<string?> invoke = MyClass.InvokeStaticFunc;
            invoke.Should().NotThrow();
        }
        [Fact]
        public void FuncEvent_MultibleSubscribersTest()
        {
            Func<string> myFunc = () => "return value";
            Func<string> myOtherFunc = () => "other return value";
            MyClass.MyStaticEventFunc += myFunc;
            MyClass.MyStaticEventFunc += myOtherFunc;

            Func<string?> invoke = MyClass.InvokeStaticFunc;
            invoke.Should().NotThrow();

            //will only return one of the subscribers value
            var result = invoke.Invoke();
        }
        [Fact]
        public void GetMembers()
        {
            var members = typeof(MyClass).GetMembers();
            var privateMembers = typeof(MyClass).GetMembers(BindingFlags.NonPublic);
            var publicMembers = typeof(MyClass).GetMembers(BindingFlags.Public);

            members.Should().NotBeEmpty();
            privateMembers.Should().NotBeEmpty();
            publicMembers.Should().NotBeEmpty();
        }
        [Fact]
        public void GetFields()
        {
            var fields = typeof(MyClass).GetFields();
            fields.Should().NotBeEmpty();
        }
        [Fact]
        public void GetProperties()
        {
            var properties = typeof(MyClass).GetProperties();
            properties.Should().NotBeEmpty();
        }
    }
}