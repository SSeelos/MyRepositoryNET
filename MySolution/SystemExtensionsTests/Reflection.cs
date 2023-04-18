using System.Reflection;

namespace SystemExtensionsTests
{
    public class Reflection
    {
        [Fact]
        public void ModuleTest()
        {
            Module module = this.GetType().Module;

            Assembly assembly = module.Assembly;
        }
    }
}