﻿using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;

namespace SampleMVVM.ViewModels
{
    internal class SearchViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Search";

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.SearchiOS;

        public IPaneElement PaneElement { get; }

        /// <summary>
        /// For Design-time support
        /// </summary>
        public SearchViewModel()
        {
        }

        private INavigator Navigator { get; }

        public SearchViewModel(INavigator navigator)
        {
            Navigator = navigator;
            PaneElement = new PaneButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
        }
    }
}