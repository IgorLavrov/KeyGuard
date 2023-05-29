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
    public partial class IndexAccountPage : ContentPage
    {
        public IndexAccountPage()
        {
            InitializeComponent();

        }

        private void SaveAccount(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            if (!String.IsNullOrEmpty(account.SourceName))
            {
                App.Database.SaveItem(account);
            }
            this.Navigation.PopAsync();
        }

        private void DeleteAccount(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            App.Database.Delete(account.Id);
            this.Navigation.PopAsync();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}