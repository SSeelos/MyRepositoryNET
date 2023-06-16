namespace MyRootNamespace.MyClassLibraryNET
{
    public abstract class _MyAttribute : Attribute
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
        public _MyAttribute(string myPositionalParameter)
        {
            this.myPositionalParameter = myPositionalParameter;
        }
    }
}
