namespace MyRootNamespace.MyClassLibraryNET
{
    [AttributeUsage(AttributeTargets.Property)]
    sealed class MyPropertyTargetAttribute : _MyAttribute
    {
        public MyPropertyTargetAttribute(string positionalParameter)
            : base(positionalParameter)
        {
        }
    }
}
