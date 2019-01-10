using DemoMobileApp.Model;
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
	public partial class ActivityDetailPage : ContentPage
	{
		public ActivityDetailPage (Activity activity)
		{
            BindingContext = activity;
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        
    }
}