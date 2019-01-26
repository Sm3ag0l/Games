﻿using Autofac;
using Games.Plugin.Sudoku.Database;
using Games.Plugin.Sudoku.GamePlan;
using Games.Plugin.Sudoku.GamePlan.Compare;
using Games.Plugin.Sudoku.GameSudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Plugin.Sudoku.ContainerConfig
{
    public static class ContainerConfig
    {       
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SudokuPlugin>().As<ISudokuPlugin>();
            builder.RegisterType<DatabaseAccess>().As<IDatabaseAccess>();
            builder.RegisterType<TestDatabase>().As<IDatabase>();
            builder.RegisterType<GamePlanViewModel>().As<IGamePlanViewModel>();
            builder.RegisterType<HashValues>().As<IHashValues>();
            builder.RegisterType<CompareGamePlans>().As<ICompareGamePlans>();
            builder.RegisterType<GameSudokuViewModel>().As<IGameSudokuViewModel>();

            return builder.Build();
        }
    }
}
