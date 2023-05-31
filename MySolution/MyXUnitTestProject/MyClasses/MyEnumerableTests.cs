namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class MyEnumerableTests
    {
        [Fact()]
        public void MyEnumerableTest()
        {
            var myEnumerable = new MyEnumerable();
            myEnumerable.MyData = new List<string> { "a", "b", "c" };

            foreach (var item in myEnumerable)
            {

            }
        }
        [Fact()]
        public void MyEnumTest()
        {
            var myEnumerable = new MyEnum();
            myEnumerable.MyData = new List<string> { "a", "b", "c" };

            foreach (var item in myEnumerable)
            {

            }
        }
        [Fact()]
        public void MyEnumerableTTest()
        {
            var myEnumerable = new MyEnumerable<string>();
            myEnumerable.MyData = new List<string> { "a", "b", "c" };

            foreach (var item in myEnumerable)
            {

            }
        }
    }
}