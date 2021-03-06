﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GUI.Navigation
{
    public class DeletePageViewModel: INotifyPropertyChanged
    {
        public DeletePageViewModel()
        {
            source = "DeletePage.xaml";
            deletedName = "Enter an ID";
        }

        private string _source;
        public string source
        {
            get { return _source; }
            set { _source = value; }
        }

        //Confirmation of deleted rebel, name to be displayed in popup
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

        private string _deletedName;
        public string deletedName
        {
            get { return _deletedName; }
            set { _deletedName = value; }
        }
        

        private ICommand _DeleteButton;
        public ICommand DeleteButton
        {
            get 
            {
                if (_DeleteButton == null)
                {
                    _DeleteButton = new Command<string>(DeleteRebel, CanDeleteRebel);
                }
                return _DeleteButton; 
            }
            set { _DeleteButton = value; }
        }


        private ICommand _DeleteButton2;
        public ICommand DeleteButton2
        {
            get
            {
                if (_DeleteButton2 == null)
                {
                    _DeleteButton2 = new Command<string>(DeleteRebel2, CanDeleteRebel);
                }
                return _DeleteButton2;
            }
            set { _DeleteButton2 = value; }
        }

        int value;


        private bool CanDeleteRebel(string Id)
        {
            return true;
        }
        private void DeleteRebel(string Id)
        {
            if (int.TryParse(Id,out value))
            {
                int IdToInt = int.Parse(Id);
                //deletedName = delete.DeleteRebelWCF(IdToInt);
                MessageBox.Show("Our fallen comrade died well, may he rest in peace.");
            }
            else
            {
                MessageBox.Show("Enter Id");
            }


        }

        private void DeleteRebel2(string Id)
        {
            if (int.TryParse(Id, out value))
            {
                int IdToInt = int.Parse(Id);
                //deletedName = delete.DeleteRebelWCF(IdToInt);
                MessageBox.Show("This treacherous scum will burn in the fire of a thousand desert suns!");
            }
            else
            {
                MessageBox.Show("Enter Id");
            }


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
