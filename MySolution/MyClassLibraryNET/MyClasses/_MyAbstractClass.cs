namespace MyRootNamespace.MyClassLibraryNET;

/// <summary>
/// base class
/// </summary>
public abstract class _MyAbstractClass : IMyInterfaceC
{
    public static string _myStaticProperty;

    //only accessible from this class
    private string? _myField;
    //only accessible from derived classes
    protected string? _myProtectedField;

    public _MyAbstractClass()
    {

    }
    public _MyAbstractClass(string fieldValue)
    {
        this._myField = fieldValue;
    }

    public void MyMethodFromBase()
    {
        throw new NotImplementedException();
    }
    public void MyInterfaceC_Method()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// derived classes MUST override abstract methods
    /// </summary>
    protected abstract void MyProtectedAbstractMethod();
    /// <summary>
    /// derived classes MUST override abstract methods
    /// </summary>
    public abstract void MyAbstractMethod();

    /// <summary>
    /// derived classes CAN override virtual method (default implementation)
    /// </summary>
    protected virtual void MyProtectedVirtualMethod()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// derived classes CAN override virtual method (default implementation)
    /// </summary>
    public virtual void MyVirtualMethod()
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// use the new keyword in the derived class to test the behaviour
    /// (any derived class cast to this abstract class will call this method rather than the "new" method of the derived class)
    /// </summary>
    public string MyNewMethod()
    {
        throw new NotImplementedException();
    }
}
