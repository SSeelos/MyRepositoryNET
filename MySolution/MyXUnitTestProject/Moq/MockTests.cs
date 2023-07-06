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

    [Fact]
    public void MockRaise()
    {
        var mock = new Mock<IMyInterfaceActionIn>();
        string argument = "";

        mock.Object.MyAction += (arg) => argument = arg;
        mock.Raise(_ => _.MyAction += null, "myArg");

        mock.VerifyAll();
        argument.Should().Be("myArg");
    }

    private void _MyAction()
    {
        Console.WriteLine("MyAction");
    }
}
