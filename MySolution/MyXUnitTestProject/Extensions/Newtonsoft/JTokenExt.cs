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
            string? value = jObj.GetTokenValue<string>("myString");
            value.Should().Be("myValue");
        }
        [Fact]
        public void GetValue_ArrayTest()
        {
            var jObj = JObject.Parse("{myArray: ['A','B']}");
            JArray? value = jObj.GetTokenValue<JArray>("myArray");
            value.Should().NotBeNull();
        }

    }
}
