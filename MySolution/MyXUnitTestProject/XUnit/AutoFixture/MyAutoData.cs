using AutoFixture;

namespace MyXUnitTestProject
{
    public class MyAutoData
    {
        [Theory, AutoData]
        public void MyAutoDataTheory(MyClassDataA myclass)
        {
            myclass.Should().NotBeNull();
            myclass.AsEnumerable().Should()
                .ContainEquivalentOf(new object[] { 1, "1A" }).And
                .ContainEquivalentOf(new object[] { 2, "2A" });
        }
    }
}
