namespace MyRootNamespace.MyClassLibraryNET
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed class MyClassTargetAttribute : _MyAttribute
    {
        readonly string myPositionalParameterB;
        /// <summary>
        /// must be specified in the order in which they appear
        /// </summary>
        public string MyPositionalParameterB
            => myPositionalParameterB;
        /// <summary>
        /// can be assigned initial values by using their names
        /// </summary>
        public string MyNamedParameterB { get; set; }

        public MyClassTargetAttribute(string parameterA, string parameterB)
            : base(parameterA)
        {
            this.myPositionalParameterB = parameterB;
        }


    }
}
