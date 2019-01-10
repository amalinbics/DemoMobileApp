using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DemoMobileApp.Service;
using DemoMobileApp.Model;

namespace DemoMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityPage : ContentPage
	{
        
		public ActivityPage ()
		{
			InitializeComponent ();

            lvActivity.ItemsSource = ActivityService.Get();
		}

        private void lvActivity_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var activity = e.SelectedItem as Activity;
            Navigation.PushAsync(new ActivityDetailPage(activity));
        }
    }
}