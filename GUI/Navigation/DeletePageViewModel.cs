using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Navigation
{
    public class DeletePageViewModel
    {
        private string _source;
        public string source
        {
            get { return _source; }
            set { _source = value; }
        }

        public DeletePageViewModel()
        {
            source = "DeletePage.xaml";
        }
    }
}
