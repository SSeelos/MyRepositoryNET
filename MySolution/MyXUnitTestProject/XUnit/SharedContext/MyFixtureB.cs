namespace MyXUnitTestProject
{
    public class MyFixtureB
    {
        public string? Data { get; private set; }
        public MyFixtureB()
        {
            Data = this.GetType().Name + nameof(Data);
        }

        public void Dispose()
        {
            Data = null;
        }
    }
}
