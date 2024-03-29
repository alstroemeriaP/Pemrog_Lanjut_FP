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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CreateButton(object sender, RoutedEventArgs e)
        {
            var create = new Create();
            NavigationService.Navigate(create);
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            var mainmenu = new MainMenu();
            NavigationService.Navigate(mainmenu);
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
