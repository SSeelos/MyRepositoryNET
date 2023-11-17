namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class Tests
    {
        [Fact()]
        public void RunPartialMethodTest()
        {
            var myPartialClass = new MyPartialClass();
            var result = myPartialClass.RunPartialMethodRef("expected");

            result.Should().Be("expected" + "MyPartialMethodRef");
        }

        [Fact()]
        public void UseGeneratedClassTest()
        {
            MySourceGeneratorUser.UseGeneratedClass();
        }

        [Fact()]
        public void MyNewMethodTest()
        {
            var c = new MyDerivedClass();

            string result = c.MyNewMethod();
            string casted = ((MyClass)c).MyNewMethod();
            string castedAbs = ((_MyAbstractClass)c).MyNewMethod();

            result.Should().Be("MyDerivedClass.MyNewMethod()");
            casted.Should().Be("MyClass.MyNewMethod()");
            castedAbs.Should().Be("_MyAbstractClass.MyNewMethod()");
        }

    }
}