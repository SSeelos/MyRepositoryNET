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

        [Theory, InlineAutoData(1, "2", 3.0)]
        public void MyInlineAutoDataTheory(int id, string data, double value, MyClassDataA myclass)
        {
            id.Should().Be(1);
            data.Should().Be("2");
            value.Should().Be(3.0);

            myclass.Should().NotBeNull();
            myclass.AsEnumerable().Should()
                .ContainEquivalentOf(new object[] { 1, "1A" }).And
                .ContainEquivalentOf(new object[] { 2, "2A" });
        }
    }
}
