using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TempViewModel : INotifyPropertyChanged
    {
        private string _source;
        public string source
        {
            get { return _source; }
            set
            {
                _source = value;
                onPropertyChanged("source");
            }
        }

        public TempViewModel()
        {
            source = "HomePage.xaml";

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
