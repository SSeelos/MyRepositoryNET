namespace MyRootNamespace.MyClassLibraryNET
{
    public partial class MyPartialClass
    {
        /// <summary>
        /// implements the partial method (optional)
        /// </summary>
        partial void MyPartialMethod()
        {
            //implementation
        }
        /// <summary>
        /// implements the partial method (optional)
        /// </summary>
        /// <param name="input">adds "MyPartialMethodRef" to the input</param>
        partial void MyPartialMethodRef(ref string input)
        {
            input += nameof(MyPartialMethodRef);
        }
    }
}
