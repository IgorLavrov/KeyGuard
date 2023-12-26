//using SafeAndroid.Services;
//using SafeAndroid.Views;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;
//using Xamarin.Forms;

//namespace SafeAndroid.ViewModels
//{
//    public class LoginViewModel:INotifyPropertyChanged
//    {

//        public event PropertyChangedEventHandler PropertyChanged;

//        public  Command cmdLogin {  get; set; }
//        public Command cmdCreateAccount {  get; set; }

//        public Command cmdForgotPassword { get; set; }
//        public Command cmdSetting {  get; set; }

//        ILoginService ilog= DependencyService.Get<ILoginService>();


//        public LoginViewModel() {

//            cmdLogin = new Command(gotoMainPage);
//            cmdCreateAccount = new Command(gotoCreateAccount);
//            cmdForgotPassword = new Command(gotoForgotPassword);
//            cmdSetting = new Command(gotoSetting);


//                }

//        private void gotoSetting(object obj)
//        {
//            App.Current.MainPage.Navigation.PushAsync(new SettingPage());
//        }

//        private void gotoForgotPassword(object obj)
//        {
//            App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());

//        }

//        private void gotoCreateAccount(object obj)
//        {
//            App.Current.MainPage.Navigation.PushAsync(new CreateAccountPage());
//        }

//        private void gotoMainPage(object obj)
//        {
//            if (ilog.login(userName,password)) {

//                App.Current.MainPage.Navigation.PushAsync(new SplashPage());
//            }
//            else
//            {
//                LoginMessage = "Please enter a valid user name and password";
//                TurnLoginMessage = true;
//            }

//        }

//        public string userName;

//        public string UserName
//        {
//            get { return userName; }
//            set { userName = value;
//                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("UserName"));

//            }
//        }

//        public string password;

//        public string Password
//        {
//            get { return password; }
//            set
//            {
//               password = value;
//               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
//            }
//        }
//        private string loginMessage;
//        public string LoginMessage
//        {
//            get { return loginMessage; }
//            set
//            {
//                loginMessage = value;
//                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("loginMessage"));
//            }
//        }
//        private bool turnLoginMessage=false;
//        public bool TurnLoginMessage
//        {
//            get { return turnLoginMessage; }
//            set
//            {
//                turnLoginMessage = value;
//                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessage"));
//            }
//        }



//    }


//    }

using SafeAndroid.Services;
using SafeAndroid.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace SafeAndroid.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command cmdLogin { get; set; }
        public Command cmdCreateAccount { get; set; }
        public Command cmdForgotPassword { get; set; }
        public Command cmdSetting { get; set; }

        ILoginService ilog = DependencyService.Get<ILoginService>();

        public LoginViewModel()
        {
            cmdLogin = new Command(gotoMainPage);
            cmdCreateAccount = new Command(gotoCreateAccount);
            cmdForgotPassword = new Command(gotoForgotPassword);
            cmdSetting = new Command(gotoSetting);
        }

        private void gotoSetting(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new SettingPage());
        }

        private void gotoForgotPassword(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void gotoCreateAccount(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CreateAccountPage());
        }

        private void gotoMainPage(object obj)
        {
            if (ilog.login(userName, password))
            {
                App.Current.MainPage.Navigation.PushAsync(new SplashPage());
            }
            else
            {
                LoginMessage = "Please enter a valid user name and password";
                TurnLoginMessage = true;
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private string loginMessage;
        public string LoginMessage
        {
            get { return loginMessage; }
            set
            {
                loginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginMessage"));
            }
        }

        private bool turnLoginMessage = false;
        public bool TurnLoginMessage
        {
            get { return turnLoginMessage; }
            set
            {
                turnLoginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessage"));
            }
        }
    }
}

