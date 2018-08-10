using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ColoresBGR : ContentPage
	{
		public ColoresBGR ()
		{
			InitializeComponent ();
		}

        void CambiarColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var red = sldrojo.Value;
            var blue = sldazul.Value;
            var green = sldverde.Value;

            Color bgColor = new Color(red, green, blue);
            boxcolor.BackgroundColor = bgColor;
            lbDisplay.Text = ColorToHex(bgColor);
        }

        private string ColorToHex(Color color)
        {
            int red = (int)(color.R * 255);
            int green = (int)(color.G * 255);
            int blue = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            return $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}