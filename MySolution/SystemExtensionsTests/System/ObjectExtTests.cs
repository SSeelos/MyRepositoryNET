namespace SystemExtensions.Tests
{
    public class ObjectExtTests
    {
        [Fact()]
        public void DisplayTest()
        {
            this.GetExtension().Property = "myExtensionProperty";

            this.GetExtension().Property
                .Should().Be("myExtensionProperty");
        }
    }
}