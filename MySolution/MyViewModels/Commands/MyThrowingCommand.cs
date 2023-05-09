namespace MyViewModels
{
    public class MyThrowingCommand : _Command
    {
        protected override void TryExecute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
