﻿using MyClassLibraryNetStandard2_0;
using MyViewModels.Models;
using Serilog;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyViewModels
{
    public class MainWindowVM : _MyViewModel
    {
        private string _myPropertyA = nameof(MyPropertyA);
        public string MyPropertyA
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

        private MyEnum _myEnum;

        public MyEnum MyEnum
        {
            get => _myEnum;
            set
            {
                _myEnum = value;
                OnPropertyChanged();
            }
        }

        private Type? _mySelectedType;
        public Type? MySelectedType
        {
            get => _mySelectedType;
            set
            {
                _mySelectedType = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MyModel> MyModels { get; set; }
            = new ObservableCollection<MyModel>();
        private MyModel _myModel;

        public MyModel MyModel
        {
            get => _myModel;
            set
            {
                _myModel = value;
                OnPropertyChanged();
            }
        }

        public void AddModel()
        {
            this.MyModels.Add(new MyModel()
            {
                MyPropertyA = nameof(MyPropertyA),
                MyPropertyB = nameof(MyPropertyB)
            });
        }

        //public MyVM()
        //{
        //    //AddModelCmd = new RelayCommand(AddModel);
        //}
        public readonly ILogger Logger;
        public MainWindowVM(ILogger logger)
        {
            this.Logger = logger;
        }

        public ICommand MyThrowingCommand => new MyThrowingCommand();
        public ICommand MyRelayCommand => new MyRelayCommand((d) => { }, (s) => true);
        public ICommand AddModelCmd => new MyAddCmd<MyModel>(MyModels,
            new MyModel()
            {
                MyPropertyA = nameof(MyPropertyA),
                MyPropertyB = nameof(MyPropertyB)
            });
        public ICommand ObservableCmd
            => new MyObservableCollectionCmd<MyModel>(MyModels,
            (MyModels) => MyModels.Add(new MyModel()
            {
                MyPropertyA = nameof(MyPropertyA),
                MyPropertyB = nameof(MyPropertyB)
            }));
    }
}
