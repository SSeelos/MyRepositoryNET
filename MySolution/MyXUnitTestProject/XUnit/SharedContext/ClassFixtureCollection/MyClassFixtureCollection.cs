namespace MyXUnitTestProject
{
    /// <summary>
    /// will never be created,
    /// treats each test class of this collection as if it implements <see cref="IClassFixture{TFixture}"/>,
    /// </summary>
    [CollectionDefinition(nameof(MyClassFixtureCollection))]
    public class MyClassFixtureCollection :
        IClassFixture<MyFixtureA>,
        IClassFixture<MyFixtureB>
    {
    }
}
