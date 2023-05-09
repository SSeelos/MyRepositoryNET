using CommunityToolkit.Mvvm.ComponentModel;

namespace MyViewModels.CommunityToolkit
{
    public class ThrowingCommand : _Command<ObservableObject>
    {
        public ThrowingCommand(ObservableObject observable)
            : base(observable)
        {
        }

        protected override void TryExecute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
