namespace SystemExtensions.CompilerServices.Tests
{
    public class MethodInfoExtTests
    {
        delegate void myDelegate();
        private void MyMethod() { }
        private interface ITestInterface
        {
            void TestMethod();
        }
        private class TestClass : ITestInterface
        {
            public void TestMethod()
            {
            }
        }

        [Fact()]
        public void DisplayTest()
        {
            myDelegate del = MyMethod;

            del.Method.Display()
                .Should().Be($"{nameof(MethodInfoExtTests)}.{nameof(MyMethod)}");
        }
    }
}