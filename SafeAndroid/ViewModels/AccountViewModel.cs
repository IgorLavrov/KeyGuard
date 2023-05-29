using SafeAndroid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SafeAndroid.ViewModels
{
    public class AccountViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        AccountListViewModel lvm;
        public Account Account { get; private set; }

        public AccountViewModel()
        {
            Account = new Account();
        }

        public AccountListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string SourceName
        {
            get { return Account.SourceName; }
            set
            {
                if (Account.SourceName != value)
                {
                    Account.SourceName = value;
                    OnPropertyChanged("SourseName");
                }
            }
        }

        public string UserName
        {
            get { return Account.UserName; }
            set
            {
                if (Account.UserName != value)
                {
                    Account.UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        public string Password
        {
            get { return Account.Password; }
            set
            {
                if (Account.Password != value)
                {
                    Account.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string Link
        {
            get { return Account.Link; }
            set
            {
                if (Account.Link != value)
                {
                    Account.Link = value;
                    OnPropertyChanged("Link");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(SourceName.Trim()))) ||
                    (!string.IsNullOrEmpty(UserName.Trim())) ||
                    (!string.IsNullOrEmpty(Password.Trim())) ||
                    (!string.IsNullOrEmpty(Link.Trim()));
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
