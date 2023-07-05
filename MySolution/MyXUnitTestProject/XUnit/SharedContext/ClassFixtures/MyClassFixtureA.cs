namespace MyXUnitTestProject
{
    /// <summary>
    /// For each test, it will create a new instance of <see cref="MyClassFixtureA"/>,
    /// and pass a shared instance of <see cref="MyFixtureA"/> to the constructor.
    /// </summary>
    public class MyClassFixtureA : IClassFixture<MyFixtureA>
    {
        MyFixtureA myFixtureA;
        public MyClassFixtureA(MyFixtureA myFixtureA)
        {
            this.myFixtureA = myFixtureA;
        }

        [Fact]
        public void MyFactA()
        {
            var result = myFixtureA.Data + nameof(MyFactA);
            Assert.Equal("MyFixtureADataMyFactA", result);
        }

        [Fact]
        public void MyFactB()
        {
            var result = myFixtureA.Data + nameof(MyFactB);
            Assert.Equal("MyFixtureADataMyFactB", result);
        }


    }
}
