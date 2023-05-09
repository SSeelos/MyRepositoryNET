namespace MyViewModels.Models
{
    public class MyNotifierModel : _Model
    {
        private string? _myPropertyA;
        public string? MyPropertyA
        {
            get => _myPropertyA;
            set
            {
                OnPropertyChanging();
                _myPropertyA = value;
                OnPropertyChanged();
            }
        }
        private string? _myPropertyB;
        public string? MyPropertyB
        {
            get => _myPropertyB;
            set
            {
                OnPropertyChanging();
                _myPropertyB = value;
                OnPropertyChanged();
            }
        }
    }
}
