using System.ComponentModel;
using SE.Geospatial.Mobile.Viewer.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TouchTrackingEffectDemos.Controls.MapViewGrid), typeof(MapViewRenderer))]
namespace SE.Geospatial.Mobile.Viewer.iOS
{
    public class MapViewRenderer : ViewRenderer<TouchTrackingEffectDemos.Controls.MapViewGrid, Esri.ArcGISRuntime.UI.Controls.MapView>
    {        
        Esri.ArcGISRuntime.UI.Controls.MapView _esriMapView;

        protected override void OnElementChanged(ElementChangedEventArgs<TouchTrackingEffectDemos.Controls.MapViewGrid> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}