using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndroid.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash",MainLauncher =true, Icon = "@drawable/logo",NoHistory =true,Label ="Keyguard")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            System.Threading.Thread.Sleep(600);
            StartActivity(typeof(MainActivity));
            // Create your application here
        }

        //protected override void OnResume()
        //{
        //    base.OnResume();
        //    //SetContentView(Resource.Layout.splash);
        //    Task startupwork = new Task(() => { SimulateStartupAsync(); });
        //    startupwork.Start(); 
        //}

        //private async Task SimulateStartupAsync()
        //{
        //    await Task.Delay(1000);
        //    StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        //}

    }
}