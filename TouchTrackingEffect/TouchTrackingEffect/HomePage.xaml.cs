using System;
using System.Windows.Input;
using Esri.ArcGISRuntime.Mapping;
using TouchTracking;
using Xamarin.Forms;

namespace TouchTrackingEffectDemos
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();


            MyMapView.Map = new Map(
                BasemapType.Imagery, // use the Imagery basemap
                42.175131,           // latitude
                9.192313,            // longitude
                8                    // level of detail (lower number = smaller scale))
                );
            BindingContext = this;
        }



        private void TouchEffect_BoxView(object sender, TouchActionEventArgs args)
        {
            DisplayAlert("touch", "box view", "close");
        }

        private void TouchEffect_MapView(object sender, TouchActionEventArgs args)
        {
            DisplayAlert("touch", "map view", "close");
        }
    }
}