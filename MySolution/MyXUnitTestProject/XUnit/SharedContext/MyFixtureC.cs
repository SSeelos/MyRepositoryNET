namespace MyXUnitTestProject
{
    public class MyFixtureC
    {
        public string? Data { get; private set; }
        public MyFixtureC()
        {
            Data = this.GetType().Name + nameof(Data);
        }

        public void Dispose()
        {
            Data = null;
        }
    }
}
