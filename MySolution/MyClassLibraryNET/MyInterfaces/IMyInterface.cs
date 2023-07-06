namespace MyRootNamespace.MyClassLibraryNET;

public interface IMyInterfaceA
{
    void MyInterfaceA_Method();
}
public interface IMyInterfaceB
{
    void MyInterfaceB_Method();
}
/// <summary>
/// pseudo interface combining <see cref="IMyInterfaceA"/> and <see cref="IMyInterfaceB"/>
/// </summary>
public interface IMyInterfaceAB : IMyInterfaceA, IMyInterfaceB
{ }
public interface IMyInterfaceC
{
    void MyInterfaceC_Method();
}
