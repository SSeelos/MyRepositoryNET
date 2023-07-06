using System.Collections;

namespace MyXUnitTestProject
{
    public class MyClassDataA : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
            => new List<object[]>()
            {
                new object[] { 1,"1A"},
                new object[] { 2,"2A"},
            }
            .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
