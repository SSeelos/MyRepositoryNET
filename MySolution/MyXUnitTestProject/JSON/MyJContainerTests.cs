using Newtonsoft.Json.Linq;

namespace MyXUnitTestProject
{
    public class MyJContainerTests
    {

        [Fact]
        public void MegeTest()
        {
            var tokenA = JToken.FromObject(new { MyPropertyA = "myValueA" });
            var tokenB = JToken.FromObject(new { MyPropertyB = "myValueB" });
            var tokenC = JToken.FromObject(new { MyPropertyC = "myValueC" });
            JObject jObjectA = new JObject();
            jObjectA.Add(tokenA);
            jObjectA.Add(tokenB);
            var jObjectB = new JObject();
            jObjectB.Add(tokenB);
            jObjectB.Add(tokenC);

            jObjectA.Merge(jObjectB);
        }

    }
}
