namespace MyXUnitTestProject
{
    [Collection(nameof(MyCollectionFixtures))]
    public class MyCollectionTestsC : IClassFixture<MyFixtureC>
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        MyFixtureC myFixtureC;
        public MyCollectionTestsC(MyFixtureA myFixtureA, MyFixtureB myFixtureB, MyFixtureC myFixtureC)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
            this.myFixtureC = myFixtureC;
        }

        [Fact]
        public void MyFactA()
        {
            var resultA = myFixtureA.Data + nameof(MyFactA);
            var resultB = myFixtureB.Data + nameof(MyFactA);
            var resultC = myFixtureC.Data + nameof(MyFactA);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactA", resultA);
            Assert.Equal(nameof(MyFixtureB) + "DataMyFactA", resultB);
            Assert.Equal(nameof(MyFixtureC) + "DataMyFactA", resultC);
        }
        [Fact]
        public void MyFactB()
        {
            var resultA = myFixtureA.Data + nameof(MyFactB);
            var resultB = myFixtureB.Data + nameof(MyFactB);
            var resultC = myFixtureC.Data + nameof(MyFactB);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactB", resultA);
            Assert.Equal(nameof(MyFixtureB) + "DataMyFactB", resultB);
            Assert.Equal(nameof(MyFixtureC) + "DataMyFactB", resultC);
        }

    }
}
