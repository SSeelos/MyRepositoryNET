namespace MyViewModels.CommunityToolkit
{
    public class MyCommand : _Command<MyObservableVM>
    {
        public MyCommand(MyObservableVM observable)
            : base(observable)
        {
        }
        protected override void TryExecute(object? parameter)
        {
            this.observable.MyProperty = $"changed by {this.GetType().Name}";
        }
    }
}
