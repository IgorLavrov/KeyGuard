using Android.Icu.Text;
using SafeAndroid.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using SafeAndroid;
using Android.Content;
using Android.Graphics.Drawables;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]

namespace SafeAndroid.Droid
{
    
    public class MyEntryRenderer: EntryRenderer
    {
        public MyEntryRenderer(Context context):base(context)
        {
            //AutoPackage = false;
        }

        //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        //{
        //    base.OnElementChanged(e);
        //    if (Control != null) 
        //    { 
        //        Control.SetBackgroundColor(Android.Graphics.Color.Transparent);

        //    }
        //}

        public MyEntry ElementV2 => Element as MyEntry;
        protected override FormsEditText CreateNativeControl()
        {
            var control = base.CreateNativeControl();
            UpdateBackground(control);
            return control;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == MyEntry.CornerRadiusProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == MyEntry.BorderThicknessProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == MyEntry.BorderColorProperty.PropertyName)
            {
                UpdateBackground();
            }

            base.OnElementPropertyChanged(sender, e);
        }

        protected override void UpdateBackgroundColor()
        {
            UpdateBackground();
        }
        protected void UpdateBackground(FormsEditText control)
        {
            if (control == null) return;

            var gd = new GradientDrawable();
            gd.SetColor(Element.BackgroundColor.ToAndroid());
            gd.SetCornerRadius(Context.ToPixels(ElementV2.CornerRadius));
            gd.SetStroke((int)Context.ToPixels(ElementV2.BorderThickness), ElementV2.BorderColor.ToAndroid());
            control.SetBackground(gd);

            var padTop = (int)Context.ToPixels(ElementV2.Padding.Top);
            var padBottom = (int)Context.ToPixels(ElementV2.Padding.Bottom);
            var padLeft = (int)Context.ToPixels(ElementV2.Padding.Left);
            var padRight = (int)Context.ToPixels(ElementV2.Padding.Right);

            control.SetPadding(padLeft, padTop, padRight, padBottom);
        }
        protected void UpdateBackground()
        {
            UpdateBackground(Control);
        }
    }

}
