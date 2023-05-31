using System.Collections;

namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyEnumerable : IEnumerable
    {
        public IEnumerable MyData = Enumerable.Empty<object>();
        public IEnumerator GetEnumerator()
        {
            foreach (var item in MyData)
            {
                yield return item;
            }
        }
    }
    /// <summary>
    /// a class does not have to implement <see cref="IEnumerable"/> to support foreach.
    /// all that is required is that the class has a public <see cref="GetEnumerator"/> method
    /// </summary>
    public class MyEnum
    {
        public IEnumerable MyData = Enumerable.Empty<object>();
        public IEnumerator GetEnumerator()
        {
            foreach (var item in MyData)
            {
                yield return item;
            }
        }
    }
}
