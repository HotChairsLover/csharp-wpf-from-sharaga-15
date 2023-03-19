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
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public MainWindow mainWindow;
        public Contacts(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            MessageBox.Show("Заявление подано, можете закрыть программу");
        }

        private void OpenChat(object sender, EventArgs e)
        {
            mainWindow.frame.NavigationService.Navigate(new ChatUser(mainWindow, 4));
        }

        private void OpenProfile(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Login(mainWindow));
        }

        private void PrevPage(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Scans(mainWindow));
        }
    }
}
