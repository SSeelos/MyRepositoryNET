using SystemExtensions;

namespace MyXUnitTestProject
{
    public class MyJsonSerializeTests : IDisposable
    {
        string path;
        public MyJsonSerializeTests()
        {
            var directory = DirectoryExt.GetCurrent().GetElder(f => f.Extension == ".sln");
            path = Path.Combine(directory.FullName, "myJSON.json");
        }

        public void Dispose()
        {
            path = null;
        }

        [Fact()]
        public void JObject_Parse()
        {
            File.WriteAllText(path, "");
        }
    }
}
