using Newtonsoft.Json;
using SystemExtensions;

namespace MyXUnitTestProject
{
    public class MyJsonDeserializeTests : IDisposable
    {
        string json;
        public MyJsonDeserializeTests()
        {
            var directory = DirectoryExt.GetCurrent().GetElder(file => file.Extension == ".sln");
            var jsonPath = Path.Combine(directory.FullName, "myJSON.json");
            json = File.ReadAllText(jsonPath);
        }

        public void Dispose()
        {
            json = null;
        }

        [Fact()]
        public void MyMethodTest()
        {
            ClassToSerialize? deserializedClass = JsonConvert.DeserializeObject<ClassToSerialize>(json);
            deserializedClass.Should().NotBeNull();
            deserializedClass.MyPropertyA.Should().Be("myValueA");
        }

    }
}
