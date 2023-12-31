﻿using SportsFinal.Models;
using SportsFinal.ViewModels;
using System;
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
using SportsFinal;
using SportsFinal.SportsLibrary;

namespace SportsFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToLacrossePage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new LacrossePage());
        }

        private void ToHockeyPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HockeyPage());
        }
    }
}
