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
using System.Windows.Shapes;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Bonnen.xaml
    /// </summary>
    public partial class Bonnen : Window
    {
        public Bonnen()
        {
            InitializeComponent();
        }

        private void ShowTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
