using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SafeAndroid
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            Style = (Style)Application.Current.Resources["AppBackground"];
        }
    }
}