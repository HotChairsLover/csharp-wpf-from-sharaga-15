﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SomeName.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataBaseView.xaml
    /// </summary>
    public partial class DataBaseView : Page
    {
        public MainWindow mainWindow;
        public DataBaseView(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 550;
            mainWindow.Width = 800;
        }

        private void NextPage(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new Stats(mainWindow));
        }

        private void DeleteDB(object sender, EventArgs e)
        {

        }

        private void ChangeDB(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new DBAdd(mainWindow, true));
        }

        private void AddDB(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new DBAdd(mainWindow, false));
        }

        private void OpenChat(object sender, EventArgs e)
        {
            mainWindow.frame.NavigationService.Navigate(new ChatAdm(mainWindow, 1));
        }

        private void ExitProfile(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Statement(mainWindow));
        }
    }
}
