using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitAccounting.Core;

namespace SplitAccounting.MVVM.ViewModel
{
    internal class MainViewModel : ObsevableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                onPorpertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(p =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(p =>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}