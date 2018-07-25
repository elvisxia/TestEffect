using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEffect;
using TestEffect.UWP;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly:ExportRenderer(typeof(MyRectangle),typeof(MyRectangleRenderer))]
namespace TestEffect.UWP
{
    public class MyRectangleRenderer:ViewRenderer<View, Windows.UI.Xaml.Shapes.Rectangle>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new Windows.UI.Xaml.Shapes.Rectangle());
                //var brush = GenerateBrush();
                //Control.Fill = brush;
            }
            if (e.NewElement != null)
            {
                Control.Width=e.NewElement.WidthRequest;
                Control.Height = e.NewElement.HeightRequest;
            }

            
        }

        private Brush GenerateBrush()
        {
            var gradientStops = new GradientStopCollection();
            gradientStops.Add(new GradientStop
            {
                Color = Windows.UI.Colors.Green,
                Offset = 0
            });
            gradientStops.Add(new GradientStop
            {
                Color = Windows.UI.Colors.Green,
                Offset = 0
            });
            gradientStops.Add(new GradientStop
            {
                Color = Windows.UI.Colors.Red,
                Offset = 0.25
            });
            gradientStops.Add(new GradientStop
            {
                Color = Windows.UI.Colors.Blue,
                Offset = 0.75
            });
            gradientStops.Add(new GradientStop
            {
                Color = Windows.UI.Colors.LimeGreen,
                Offset = 1
            });
            var brush = new LinearGradientBrush(gradientStops, 0);
            brush.StartPoint = new Windows.Foundation.Point(0, 0);
            brush.EndPoint = new Windows.Foundation.Point(1, 0);
            return brush;
        }
    }

    
}
