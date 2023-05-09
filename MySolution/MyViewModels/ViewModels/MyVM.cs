﻿using MyViewModels.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyViewModels
{
    public class MyVM : _MyViewModel
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

        public ObservableCollection<MyModel> MyModels { get; set; } = new ObservableCollection<MyModel>();
        public void AddModel()
        {
            this.MyModels.Add(new MyModel() { MyPropertyA = nameof(MyPropertyA), MyPropertyB = nameof(MyPropertyB) });
        }
        //public MyModel MyModel { get; set; }
        //public MyObservableModel MyObservableModel { get; set; }

        public ICommand MyThrowingCommand => new MyThrowingCommand();
    }
}
