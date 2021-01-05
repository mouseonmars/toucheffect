﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TouchTrackingEffectDemos.Droid
{
    [Activity(Label = "TouchTrackingEffectDemos", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            Console.WriteLine("DispatchTouchEvent");
            return base.DispatchTouchEvent(ev);
        }


        public override bool OnTouchEvent(MotionEvent e)
        {
            Console.WriteLine("OnTouchEvent");
            return base.OnTouchEvent(e);
        }
    }
}

