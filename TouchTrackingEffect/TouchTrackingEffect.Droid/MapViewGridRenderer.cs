using System;
using System.ComponentModel;
using Android.App;
using Android.Content;
using Android.Views;
using TouchTrackingEffectDemos.Android.Renderer;
using TouchTrackingEffectDemos.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MapViewGrid), typeof(MapViewGridRenderer))]

namespace TouchTrackingEffectDemos.Android.Renderer
{
    public class MapViewGridRenderer : ViewRenderer
    {
        private Context _context;

        public MapViewGridRenderer(Context context):base(context)
        {
            _context = context;
            // Get the Android View corresponding to the Element that the effect is attached to
            var view = Control;
            //view.Touch += View_Touch;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<global::Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            var view = this;

            view.Touch += (object sender, TouchEventArgs args) =>
            {

                AlertDialog.Builder dialog = new AlertDialog.Builder(_context);
                AlertDialog alert = dialog.Create();
                alert.SetTitle("Touch Event");
                alert.SetMessage("Detected touch event on grid");
                alert.SetButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                alert.SetButton2("CANCEL", (c, ev) => { });
                alert.Show();
            };
        }

        private void OnGridTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            return base.OnTouchEvent(e);
        }
    }
}