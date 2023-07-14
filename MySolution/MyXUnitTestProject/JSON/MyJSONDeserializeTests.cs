using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SystemExtensions;

namespace MyXUnitTestProject
{
    public class MyJSONDeserializeTests : IDisposable
    {
        string json;
        public MyJSONDeserializeTests()
        {
            var directory = DirectoryExt.GetCurrent().GetElder(f => f.Extension == ".sln");
            var jsonPath = Path.Combine(directory.FullName, "myJSON.json");
            json = File.ReadAllText(jsonPath);
        }

        public void Dispose()
        {
            json = null;
        }

        [Fact()]
        public void JObject_Parse()
        {
            var jObj = JObject.Parse(json);

            jObj.Should().NotBeNull();
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
