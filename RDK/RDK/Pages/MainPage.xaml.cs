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

namespace RDK.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new AuthorizationPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new AddEmployeePage());
        }

        private void btnAddList_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new SickLeavePage());
        }
    }
}
