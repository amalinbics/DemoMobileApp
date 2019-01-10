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
	public partial class ToolBarPage : ContentPage
	{
		public ToolBarPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "New", "OK");
        }
    }
}