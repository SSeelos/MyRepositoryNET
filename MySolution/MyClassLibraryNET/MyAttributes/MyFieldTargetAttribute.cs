namespace MyRootNamespace.MyClassLibraryNET
{
    [AttributeUsage(AttributeTargets.Field)]
    sealed class MyFieldTargetAttribute : _MyAttribute
    {
        public MyFieldTargetAttribute(string positionalParameter)
            : base(positionalParameter)
        {
        }
    }
}
