
namespace MyXUnitTestProject
{
    public class MyTests : IDisposable
    {
        string? data;
        //(optional) setup
        public MyTests()
        {
            // Arrange before each test
            data = nameof(data);
        }

        public void Dispose()
        {
            data = null;
        }

        [Fact]
        public void MyFactA()
        {
            // Act
            var result = data + nameof(MyFactA);

            // Assert
            Assert.Equal("dataMyFactA", result);
        }
        [Fact]
        public void MyFactB()
        {
            // Act
            var result = data + nameof(MyFactB);

            // Assert
            Assert.Equal("dataMyFactB", result);
        }
    }
}
