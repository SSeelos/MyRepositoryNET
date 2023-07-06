using Moq;
using MyRootNamespace.MyClassLibraryNET;
namespace MyXUnitTestProject;

public class MockTests
{
    [Fact]
    public void MockReturn()
    {
        var mock = new Mock<IMyInterfaceOut>();
        mock.Setup(_ => _.MyInterfaceMethod())
            .Returns("mockData");

        mock.Object.MyInterfaceMethod()
            .Should().Be("mockData");
    }

}
