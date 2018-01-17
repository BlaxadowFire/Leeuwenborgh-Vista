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
    /// Interaction logic for Opsplitsen.xaml
    /// </summary>
    public partial class Opsplitsen : Window
    {
        public Opsplitsen()
        {
            InitializeComponent();
        }

        private void ShowMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MenuKaart menuKaart = new MenuKaart();
            menuKaart.Show();
            this.Close();
        }
    }
}
