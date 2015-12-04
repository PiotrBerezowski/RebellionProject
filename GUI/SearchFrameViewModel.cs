using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SearchFrameViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<UserDetails> _rebelDetails;
        public ObservableCollection<UserDetails> rebelDetails
        {
            get { return _rebelDetails; }
            set
            {
                _rebelDetails = value;
                onPropertyChanged("rebelDetails");
            }
        }

        private ObservableCollection<SalesOrderDetails> _salesOrderDetails;
        public ObservableCollection<SalesOrderDetails> salesOrderDetails
        {
            get { return _salesOrderDetails; }
            set
            {
                _salesOrderDetails = value;
                onPropertyChanged("salesOrderDetails");
            }
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

        private int _productId;
        public int productId
        {
            get { return _productId; }
            set
            {
                _productId = value;
                onPropertyChanged("productId");
            }
        }

        public SearchFrameViewModel()
        {
            salesOrderDetails = new ObservableCollection<SalesOrderDetails>();
            rebelDetails = new ObservableCollection<UserDetails>();
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
