using MyRootNamespace.MyClassLibraryNET;
using Newtonsoft.Json.Linq;

namespace MyXUnitTestProject
{
    public class JTokenExt
    {
        [Fact]
        public void GetValue_StringTest()
        {
            var jObj = JObject.Parse("{'myString':'myValue'}");
            var value = jObj.GetValue<string>("myString");
            value.Should().Be("myValue");
        }
        [Fact]
        public void GetValue_ArrayTest()
        {
            var jObj = JObject.Parse("{myArray: ['A','B']}");
            var value = jObj.GetValue<JArray>("myArray");
        }

    }
}
