using GUI.MyServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GUI.Navigation
{
    public class AddPageViewModel : INotifyPropertyChanged
    {
        private string _source;
        public string source
        {
            get { return _source; }
            set { _source = value; }
        }

        public AddPageViewModel()
        {
            source = "AddPage.xaml";
        }

        private int _rebelId;
        public int rebelId
        {
            get { return _rebelId; }
            set
            {
                _rebelId = value;
                onPropertyChanged("rebelId");
            }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                onPropertyChanged("name");
            }
        }

        private int _groupId;
        public int groupId
        {
            get { return _groupId; }
            set { _groupId = value; 
                onPropertyChanged("groupId"); }
        }

        private ICommand _AddButtonCommand;
        public ICommand AddButtonCommand
        {
            get
            {
                if (_AddButtonCommand == null)
                {
                    _AddButtonCommand = new Command(AddCommand, CanAddCommand);
                }
                return _AddButtonCommand;
            }
            set { _AddButtonCommand = value; }
        }

        private bool CanAddCommand()
        {
            return true;
        }

        private void AddCommand()
        {
            RebellionDatabaseClient proxy = new RebellionDatabaseClient();
            if (proxy.FindRebel(rebelId) == null)
            {
                proxy.createNewRebel(name, rebelId, groupId);
                MessageBox.Show("The rebel " + name + " has been added to the alliance. Welcome, comrade! DOWN WITH THE OVERLOADS!");
                rebelId = 0;
                groupId = 0;
                name = string.Empty;
            }
            else
                MessageBox.Show("Sorry, a rebel is already associated with ID number " + rebelId + ". Please try another ID.");
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
