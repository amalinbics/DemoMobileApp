using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
        string baseUri = "http://lorempixel.com/1920/1080/city/";
        int current = 1;
      
		public ImagePage ()
		{
			InitializeComponent ();

            image.Source = new UriImageSource {
                Uri = new Uri(string.Format("{0}{1}/", baseUri, current)),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
		}

        private void btnPrev_Clicked(object sender, EventArgs e)
        {
            current = current < 10 ? current == 1 ? 10 : current -1 : current - 1;
            string uri = string.Format("{0}{1}/", baseUri, current);
            Console.WriteLine(uri);
            image.Source = new UriImageSource
            {
                Uri = new Uri(uri),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            current = current = current < 10 ? current+1 : 1;
            string uri = string.Format("{0}{1}/", baseUri, current);

            Console.WriteLine(uri);

            image.Source = new UriImageSource
            {
                Uri = new Uri(uri),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }
    }
}