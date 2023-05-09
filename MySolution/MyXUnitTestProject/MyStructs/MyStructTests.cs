namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class MyStructTests
    {
        readonly MyStruct myStruct;
        public MyStructTests()
        {
            this.myStruct = new MyStruct
            {
                MyInitA = nameof(MyStruct.MyInitA),
                MyInitB = nameof(MyStruct.MyInitB)
            };
        }
        [Fact()]
        public void MyStructTest()
        {
            this.myStruct.Should().NotBeNull();
        }
        [Fact()]
        public void MyStructWithTest()
        {
            var myStruct = new MyStruct()
            {
                //MyInit = nameof(MyStruct.MyInit),
                MyProperty = nameof(MyStruct.MyProperty)
            };
            var with = myStruct with { MyProperty = myStruct.MyInitA + "with" };
            with.Should().NotBeNull();
            with.MyInitA.Should().Be(myStruct.MyInitA + "with");
        }
        [Fact]
        public void EqualsTest()
        {
            var other = new MyStruct
            {
                MyInitA = nameof(MyStruct.MyInitA),
                MyInitB = nameof(MyStruct.MyInitB)
            };

            //in contrast to a reference types,
            //struct types are equal if all values of the properties are equal.
            this.myStruct.Equals(other).Should().BeTrue();

            //you cannot use the == operator with a struct type
            //unless the type explicitly overloads that operator
            //(this.myStruct == other).Should().BeTrue();
        }
    }
}