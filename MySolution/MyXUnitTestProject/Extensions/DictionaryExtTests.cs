namespace MyRootNamespace.MyClassLibraryNET.Tests
{
    public class DictionaryExtTests
    {
        [Fact()]
        public void GetGenerousTest()
        {
            var dict = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key 2", "value2" }
            };

            dict.GetGenerous("key1").Should().Be("value1");
            dict.GetGenerous("key 1").Should().Be("value1");
            dict.GetGenerous("Key1").Should().Be("value1");
            dict.GetGenerous("key2").Should().Be("value2");
            dict.GetGenerous("key 2").Should().Be("value2");
            dict.GetGenerous("Key 2").Should().Be("value2");
            dict.GetGenerous("nope").Should().Be(null);
        }
    }
}