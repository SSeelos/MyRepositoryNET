namespace MyXUnitTestProject
{
    [Collection(nameof(MyCollectionFixtures))]
    public class MyCollectionTestsA
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        public MyCollectionTestsA(MyFixtureA myFixtureA, MyFixtureB myFixtureB)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
        }

        [Fact]
        public void MyFactA()
        {
            var resultA = myFixtureA.Data + nameof(MyFactA);
            var resultB = myFixtureB.Data + nameof(MyFactA);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactA", resultA);
            Assert.Equal(nameof(MyFixtureB) + "DataMyFactA", resultB);
        }
        [Fact]
        public void MyFactB()
        {
            var resultA = myFixtureA.Data + nameof(MyFactB);
            var resultB = myFixtureB.Data + nameof(MyFactB);
            Assert.Equal(nameof(MyFixtureA) + "DataMyFactB", resultA);
            Assert.Equal(nameof(MyFixtureB) + "DataMyFactB", resultB);
        }

    }
}
