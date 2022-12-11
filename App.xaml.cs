﻿using Firma.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Firma
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //ta funkcja określa co robić po ....
            MainWindow window = new MainWindow();
            window.DataContext = new MainWindowViewModel();//to jest powiązanie View z ViewModel
            window.Show();
        }
    }
}
