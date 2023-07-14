namespace MyXUnitTestProject
{
    public class ClassToSerialize
    {
        public string MyPropertyA { get; set; }
        public IList<ClassToSerialize> MyClasses { get; set; }
    }
}
