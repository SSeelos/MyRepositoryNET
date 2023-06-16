namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class Tests
    {
        [Fact()]
        public void RunPartialMethodTest()
        {
            var myPartialClass = new MyPartialClass();
            var result = myPartialClass.RunPartialMethodRef("expected");

            result.Should().Be("expected" + "MyPartialMethod");
        }
    }
}