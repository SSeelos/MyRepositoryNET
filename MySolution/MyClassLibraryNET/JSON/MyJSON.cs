using Newtonsoft.Json.Linq;
using SystemExtensions;

namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyJSON
    {
        public void MyMethod()
        {
            var directory = DirectoryExt.GetCurrent().GetElder(f => f.Extension == ".sln");

            var json = File.ReadAllText($@"{directory}/myJSON.json");
            var jObj = JObject.Parse(json);
        }
    }
}
