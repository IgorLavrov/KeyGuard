using SafeAndroid.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SafeAndroid.ViewModels
{
    public class AccountListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AccountViewModel> Accounts { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CreateAccountCommand { get; set; }
        public ICommand DeleteAccountCommand { get; set; }
        public ICommand SaveAccountCommand { get; set; }
        public ICommand BackCommand { get; set; }

        AccountViewModel selectedAccount;
        public INavigation Navigation { get; set; }

        public AccountListViewModel()
        {
            Accounts = new ObservableCollection<AccountViewModel>();
            CreateAccountCommand = new Command(CreateAccount);
            DeleteAccountCommand = new Command(DeleteAccount);
            SaveAccountCommand = new Command(SaveAccount);
            BackCommand = new Command(Back);
        }

        public AccountViewModel SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                if (selectedAccount != value)
                {
                    AccountViewModel tempAccount = value;
                    selectedAccount = null;
                    OnPropertyChanged("SelectedAccount");
                    Navigation.PushAsync(new AccountPage(tempAccount));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateAccount()
        {
            Navigation.PushAsync(new AccountPage(new AccountViewModel() { ListViewModel = this }));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SaveAccount(object accountObject)
        {
            AccountViewModel account = accountObject as AccountViewModel;
            if (account != null && account.IsValid && !Accounts.Contains(account))
            {
                Accounts.Add(account);
            }
            Back();
        }

        private void DeleteAccount(object accountObject)
        {
            AccountViewModel account = accountObject as AccountViewModel;
            if (account != null)
            {
                Accounts.Remove(account);
            }
            Back();
        }
    }
}
