namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyComponent : IMyInterfaceA
    {
        public void MyInterfaceA_Method()
        {
            throw new NotImplementedException();
        }
    }
    public class MyComposedClass : IMyInterfaceA
    {
        public IMyInterfaceA InterfaceA { get; private set; }
        public MyComposedClass(IMyInterfaceA component)
        {
            this.InterfaceA = component;
        }
        public void MyInterfaceA_Method()
        {
            InterfaceA.MyInterfaceA_Method();
        }
    }
    public class Client
    {
        public void DoSomething()
        {
            var component = new MyComponent();
            var composed = new MyComposedClass(component);
            composed.MyInterfaceA_Method();
            composed.InterfaceA.MyInterfaceA_Method();

        }
    }
}
