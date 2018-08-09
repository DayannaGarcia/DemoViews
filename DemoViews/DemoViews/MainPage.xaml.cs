using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViews
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            timPickInicial.Time = new TimeSpan(17,0,0);
		}

        async private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            await this.DisplayAlert("Completado","Se ha completado la carga de la Pagina","Ok");
        }
    }
}
