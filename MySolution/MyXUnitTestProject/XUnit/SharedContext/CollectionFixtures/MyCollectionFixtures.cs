namespace MyXUnitTestProject
{
    /// <summary>
    /// will never be created,
    /// but will be used to pass shared instances of <see cref="MyFixtureA"/> and <see cref="MyFixtureB"/>
    /// to the constructors of classes that use this collection fixture.
    /// </summary>
    [CollectionDefinition(nameof(MyCollectionFixtures))]
    public class MyCollectionFixtures :
        ICollectionFixture<MyFixtureA>,
        ICollectionFixture<MyFixtureB>
    {
    }
}
