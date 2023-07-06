namespace MyXUnitTestProject
{
    public class MyClassDataTheory
    {
        [Theory]
        [ClassData(typeof(MyClassDataA))]
        public void MyTheory(int id, string data)
        {
            id.Should().BeOneOf(1, 2);
            data.Should().BeOneOf("1A", "2A");
        }
    }
}
