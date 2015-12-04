using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.Navigation
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        private ICommand _FindButton;
        public ICommand FindButton
        {
            get
            {
                if (_FindButton == null)
                {
                    _FindButton = new Command(GoToFindPage, CanGoToFindPage);
                }
                return _FindButton;
            }
        }

        private ICommand _AddButton;
        public ICommand AddButton
        {
            get
            {
                if (_AddButton == null)
                {
                    _AddButton = new Command(GoToAddPage, CanGoToAddPage);
                }
                return _AddButton;
            }
        }

        private ICommand _EditButton;
        public ICommand EditButton
        {
            get
            {
                if (_EditButton == null)
                {
                    _EditButton = new Command(GoToEditPage, CanGoToEditPage);
                }
                return _EditButton;
            }
            set
            {
                _EditButton = value;
            }
        }

        private ICommand _DeleteButton;
        public ICommand DeleteButton
        {
            get
            {
                if (_DeleteButton == null)
                {
                    _DeleteButton = new Command(GoToDeletePage, CanGoToDeletePage);
                }
                return _DeleteButton;
            }
            set { _DeleteButton = value; }
        }

        private bool CanGoToDeletePage()
        {
            return true;
        }

        private void GoToDeletePage()
        {
            MainWindowViewModel vm = App.Current.MainWindow.DataContext as MainWindowViewModel;
            vm.source = "Navigation/DeletePage.xaml";
        }

        private bool CanGoToEditPage()
        {
            return true;
        }

        private void GoToEditPage()
        {
            MainWindowViewModel vm = App.Current.MainWindow.DataContext as MainWindowViewModel;
            vm.source = "Navigation/EditPage.xaml";
        }

        private bool CanGoToAddPage()
        {
            return true;
        }

        private void GoToAddPage()
        {
            MainWindowViewModel vm = App.Current.MainWindow.DataContext as MainWindowViewModel;
            vm.source = "Navigation/AddPage.xaml";
        }

        private bool CanGoToFindPage()
        {
            return true;
        }

        private void GoToFindPage()
        {
            MainWindowViewModel vm = App.Current.MainWindow.DataContext as MainWindowViewModel;
            vm.source = "Navigation/FindPage.xaml";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
