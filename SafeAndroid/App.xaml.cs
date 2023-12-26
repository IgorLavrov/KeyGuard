using SafeAndroid.Services;
using SafeAndroid.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafeAndroid
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "accounts.db";
        public static AccountRepository database;
        public static AccountRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new AccountRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ILoginService, loginService>();
            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new IndexListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


    }
}
