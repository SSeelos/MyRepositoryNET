namespace MyRootNamespace.MyClassLibraryNET;

/// <summary>
/// seal custom attribute classes (faster look-up for the attribute)
/// </summary>
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

    /// <summary>
    /// initialize required arguments
    /// </summary>
    public MyAttribute(string positionalParameter)
    {
        this.myPositionalParameter = positionalParameter;
    }
}
