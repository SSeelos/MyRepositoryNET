namespace MyViewModels
{
    public class MyCommand : _Command<MyObservableVM>
    {
        public MyCommand(MyObservableVM observable)
            : base(observable)
        {
        }
        public override void Execute(object? parameter)
        {
            this.observable.MyProperty = $"changed by {this.GetType().Name}";
        }
    }
}
