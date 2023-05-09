namespace MyRootNamespace.MyClassLibraryNET;

/// <summary>
/// main pupose of storing (public) data.
/// should not have any state changes after init
/// (by default immutable reference types).
/// during runtime classes and records are the same
/// </summary>
public record MyRecord : IMyInterfaceA
{
    public string MyInitA { get; init; } = default!;
    public string MyInitB { get; init; } = default!;
    public string MyProperty { get; set; } = default!;

    public void MyInterfaceA_Method()
    {
        throw new NotImplementedException();
    }

    public void MyMethod()
    {
        throw new NotImplementedException();
    }
}
