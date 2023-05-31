using System.Collections;

namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyEnumerable<T> : IEnumerable<T>
    {
        public IEnumerable<T> MyData = Enumerable.Empty<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in MyData)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
