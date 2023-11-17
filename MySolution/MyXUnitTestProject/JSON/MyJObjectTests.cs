using MyRootNamespace.MyClassLibraryNET;
using Newtonsoft.Json.Linq;
using SystemExtensions;

namespace MyXUnitTestProject
{
    public class MyJObjectTests
    {
        string json;
        public MyJObjectTests()
        {
            var dir = DirectoryExt.GetCurrent().GetElder(file => file.Extension == ".sln");
            var filePath = Path.Combine(dir.FullName, "myObject.json");

            json = File.ReadAllText(filePath);
        }

        [Fact()]
        public void JObject_Parse()
        {
            JObject jObj = JObject.Parse(json);
            jObj.Should().NotBeNull();
            jObj.Type.Should().Be(JTokenType.Object);
        }

        [Fact]
        public void JObject_Add()
        {
            var jObj = JObject.Parse(json);
            jObj.Add("MyAddedString", "myValue");

            jObj.GetTokenValue<string>("MyAddedString")
                .Should().Be("myValue");
        }

    }
}
