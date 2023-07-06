using FluentAssertions.Execution;
namespace MyXUnitTestProject
{
    public class MyInlineDataTheory
    {
        [Theory]
        [InlineData(1, 2)]
        public void MyTheory(double paramA, double paramB)
        {
            using (new AssertionScope())
            {
                paramA.Should().Be(1);
                paramB.Should().Be(2);
            }
        }

    }
}
