using Newtonsoft.Json.Linq;
using SystemExtensions;

namespace MyXUnitTestProject
{
    public class MyJArrayTests
    {
        string json;
        public MyJArrayTests()
        {
            FileInfo? jsonFile = DirectoryExt.GetCurrent()
                .GetFilesUpwards(file => file.Name.StartsWith("myArray"))
                .FirstOrDefault();
            json = File.ReadAllText(jsonFile.FullName);
        }

        [Fact]
        public void JArrayTest()
        {
            JArray? jObject = JObject.Parse(json).SelectToken("myArray").Value<JArray>();
            JArray jArray = JArray.Parse(jObject.ToString());
            jArray.Should().NotBeNull();
        }

    }
}
