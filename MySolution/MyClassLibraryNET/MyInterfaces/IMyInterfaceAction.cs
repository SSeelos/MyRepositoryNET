namespace MyRootNamespace.MyClassLibraryNET;

public interface IMyInterfaceAction
{
    event Action MyAction;
}
public interface IMyInterfaceActionIn
{
    event Action<string> MyAction;
}
