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

namespace Games.Plugin.Sudoku.GameSudoku.NewGame
{
    /// <summary>
    /// Interaction logic for NewGameView.xaml
    /// </summary>
    public partial class NewGameView : UserControl
    {
        public NewGameView()
        {
            InitializeComponent();
        }
        public NewGameView(INewGameViewModel newGameViewModel) : this()
        {
            DataContext = newGameViewModel;
        }
    }
}
