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
	public partial class DisplayAlertPage : ContentPage
	{
		public DisplayAlertPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var resp = await DisplayAlert("Alert", "Click Yes or No", "OK", "Cancel");
            //if (resp)
            //    await DisplayAlert("Response", resp.ToString(), "OK");

            var resp = await DisplayActionSheet("Alert", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", resp, "OK");
        }
    }
}