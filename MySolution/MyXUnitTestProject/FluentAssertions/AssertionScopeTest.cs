namespace MyXUnitTestProject
{
    public class AssertionScopeTest
    {

        [Fact]
        public void Scope()
        {
            var t = "t";
            t.AssertionScope(t =>
            {
                t.Should().Be("t");
                t.Should().NotBe("fail");
            });
        }

        [Fact]
        public void ScopeFailures()
        {
            var test = "test";

            var failures = test.AssertionScopeFailures(t =>
            {
                t.Should().Be("test");
                t.Should().Be("fail");
                t.Should().Be("fail2");
            });

            failures.Should().HaveCount(2);
        }
    }
}
