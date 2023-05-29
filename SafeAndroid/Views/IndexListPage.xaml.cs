using SafeAndroid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafeAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexListPage : ContentPage
    {
        public IndexListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            accounList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        //обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Account selectedAccount = (Account)e.SelectedItem;
            IndexAccountPage accountPage = new IndexAccountPage();
            accountPage.BindingContext = selectedAccount;
            await Navigation.PushAsync(accountPage);
        }

        //обработка нажатия кнопки добавления

        private async void CreateAccount(object sender, EventArgs e)
        {
            Account account = new Account();
            IndexAccountPage accountPage = new IndexAccountPage();
            accountPage.BindingContext = account;
            await Navigation.PushAsync(accountPage);
        }
    }
}