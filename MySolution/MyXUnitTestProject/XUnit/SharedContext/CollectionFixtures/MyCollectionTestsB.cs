namespace MyXUnitTestProject
{
    [Collection(nameof(MyCollectionFixtures))]
    public class MyCollectionTestsB
    {
        MyFixtureA myFixtureA;
        public MyCollectionTestsB(MyFixtureA myFixtureA)
        {
            this.myFixtureA = myFixtureA;
        }

        [Fact]
        public void MyFactA()
        {
            var resultA = myFixtureA.Data + nameof(MyFactA);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactA", resultA);
        }
        [Fact]
        public void MyFactB()
        {
            var resultA = myFixtureA.Data + nameof(MyFactB);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactB", resultA);
        }

    }
}
