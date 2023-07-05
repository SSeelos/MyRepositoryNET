namespace MyXUnitTestProject
{
    /// <summary>
    /// Just before the first test in MyClassFixtureTests is run,
    /// xUnit.net will create an instance of MyFixtureA
    /// (cannot take dependencies on other fixtures)
    /// </summary>
    public class MyFixtureA : IDisposable
    {
        public string? Data { get; private set; }
        public MyFixtureA()
        {
            Data = this.GetType().Name + nameof(Data);
        }

        public void Dispose()
        {
            Data = null;
        }
    }
}
