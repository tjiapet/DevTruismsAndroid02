using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DevTruismsAndroid02
{
    [Activity(Label = "DevTruismsAndroid02", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };


            Switch GoodSwitch = FindViewById<Switch>(Resource.Id.switch1);
            Switch FastSwitch = FindViewById<Switch>(Resource.Id.switch2);
            Switch CheapSwitch = FindViewById<Switch>(Resource.Id.switch3);

            GoodSwitch.Click += (o, e) =>
            {
                // Perform action on clicks
                if (GoodSwitch.Checked)
                    FastSwitch.Checked = false;
            };

            FastSwitch.Click += (o, e) =>
            {
                // Perform action on clicks
                if (FastSwitch.Checked)
                    CheapSwitch.Checked = false;
            };

            CheapSwitch.Click += (o, e) =>
            {
                // Perform action on clicks
                if (CheapSwitch.Checked)
                    GoodSwitch.Checked = false;
            };

        }
    }
}

