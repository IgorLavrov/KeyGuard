﻿using SafeAndroid.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SafeAndroid
{
  public  class SplashPage:ContentPage
    {
        Image SplashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this,false);
            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "logo.jpg",
                WidthRequest = 250,
                HeightRequest = 250,
            };

            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);

            this.BackgroundColor = Color.FromHex("#429de3");
            this .Content = sub ;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SplashImage.ScaleTo(1, 2000);
            await SplashImage.ScaleTo(0.6,1300,Easing.Linear);
            await SplashImage.ScaleTo(1.7, 2000, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new IndexListPage());

        }


    }
}
