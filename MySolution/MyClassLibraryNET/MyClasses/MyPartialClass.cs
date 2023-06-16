namespace MyRootNamespace.MyClassLibraryNET
{
    public partial class MyPartialClass
    {
        /// <summary>
        /// defines a partial method that can be implemented in another file
        /// (must be private/ return void / not have any out params)
        /// </summary>
        partial void MyPartialMethod();
        /// <summary>
        /// partial method without implementation is allowed
        /// </summary>
        partial void MyPartialMethod_Uninplemented();
        /// <summary>
        /// ref is allowed
        /// </summary>
        partial void MyPartialMethodRef(ref string input);

        public string RunPartialMethodRef(string input)
        {
            MyPartialMethodRef(ref input);

            return input;
        }
    }
}
