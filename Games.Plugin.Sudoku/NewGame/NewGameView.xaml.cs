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

namespace Games.Plugin.Sudoku.NewGame
{
    /// <summary>
    /// Interaction logic for NewGameView.xaml
    /// </summary>
    public partial class NewGameView : Window
    {
        public NewGameView()
        {
            InitializeComponent();

            DataContext = new NewGameViewModel();
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Middle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Easy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}