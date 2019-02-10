﻿using Autofac;
using Base.Handler;
using Games.Plugin.Sudoku.Container;
using Games.Plugin.Sudoku.Events;
using Games.Plugin.Sudoku.GameSudoku.NewGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Games.Plugin.Sudoku.GameSudoku
{
    public class GameSudokuViewModel : OnPropertyCange, IGameSudokuViewModel
    {
        private ILifetimeScope _scope;
        private Func<Action, bool, ICommand> _commandFactory;
        private NewGameView _newGameView;
        private readonly bool _isExecutable = true;
        private INewGameViewModel _newGameViewModel;
        public int MyProperty { get; set; }

        public event EventHandler OpenNewGame;

        public ICommand NewGameCommand
        {
            get => _commandFactory(() =>
            {
                OpenNewGame?.Invoke(this, EventArgs.Empty);
            }, _isExecutable);
        }

        public GameSudokuViewModel()
        {
            _scope = ContainerScope.Scope;
            _commandFactory = _scope.Resolve<Func<Action, bool, ICommand>>();
        }
    }
}