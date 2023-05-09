namespace MyRootNamespace.MyClassLibraryNET;

public class DotNet
{
    public DotNet()
    {
        var myStandard20 = new MyClassLibraryNetStandard2_0.MyClass();
        var myStandard21 = new MyClassLibraryNetStandard2_1.MyClass();
        var myFramework = new MyClassLibraryNetFramework.MyClass();
    }
}
