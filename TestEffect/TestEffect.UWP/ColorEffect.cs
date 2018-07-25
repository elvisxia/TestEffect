using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEffect.UWP;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly:ResolutionGroupName("MyCompany")]
[assembly:ExportEffect(typeof(ColorEffect),"ColorEffect")]
namespace TestEffect.UWP
{
    public class ColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var control = Control as Windows.UI.Xaml.Shapes.Rectangle;
            control.Fill = GenerateBrush();
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
                Color = Windows.UI.Colors.Yellow,
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

        protected override void OnDetached()
        {
           
        }
    }
}
