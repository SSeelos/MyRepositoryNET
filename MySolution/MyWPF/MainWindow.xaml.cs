﻿using MyViewModels;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowVM vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}
