namespace MyRootNamespace.MyClassLibraryNET;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : Attribute
{
    readonly string myPositionalParameter;
    /// <summary>
    /// must be specified in the order in which they appear
    /// </summary>
    public string MyPositionalParameter
        => myPositionalParameter;
    /// <summary>
    /// can be assigned initial values by using their names
    /// (optional)
    /// </summary>
    public string MyNamedParameter { get; set; }

    public MyAttribute(string positionalParameter)
    {
        this.myPositionalParameter = positionalParameter;
    }


}
