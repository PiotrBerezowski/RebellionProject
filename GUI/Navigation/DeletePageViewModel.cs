using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.Navigation
{
    public class DeletePageViewModel: INotifyPropertyChanged
    {
        public DeletePageViewModel()
        {
            source = "DeletePage.xaml";
        }

        private string _source;
        public string source
        {
            get { return _source; }
            set { _source = value; }
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

        private ICommand _DeleteButton;
        public ICommand DeleteButton
        {
            get 
            {
                if (_DeleteButton == null)
                {
                    _DeleteButton = new Command(DeleteRebel, CanDeleteRebel);
                }
                return _DeleteButton; 
            }
            set { _DeleteButton = value; }
        }

        private bool CanDeleteRebel()
        {
            return true;
        }
        private void DeleteRebel()
        {
            //Do Something
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
