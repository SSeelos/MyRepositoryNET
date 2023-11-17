using MyRootNamespace.MyClassLibraryNET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyXUnitTestProject
{
    public class MyJTokenTest
    {
        [Fact]
        public void FromObjectTest()
        {
            JToken jToken = JToken.FromObject(new { MyPropertyA = "myValueA" });
            jToken.Should().NotBeNull();
            jToken.Type.Should().Be(JTokenType.Object);
        }
        [Fact]
        public void FromObjectSerializerTest()
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            JToken jToken = JToken.FromObject(new MyClass { MyAutoProperty = null, MyFullProperty = "myValue" }, serializer);
            jToken.Should().NotBeNull();
        }

        [Fact]
        public void Reader()
        {
            JToken token = JToken.FromObject(new { MyValue = "myValue" });
            JsonReader reader = token.CreateReader();
        }

    }
}
