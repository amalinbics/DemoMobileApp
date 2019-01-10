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
	public partial class ListPage : ContentPage
	{
         
        

		public ListPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Search> {
                new Search { Id =1, Location="Location1",CheckIn =Convert.ToDateTime( "10-01-2018") , CheckOut = Convert.ToDateTime( "11-01-2018") },
                new Search { Id =2, Location="Location2",CheckIn =Convert.ToDateTime( "11-01-2018") , CheckOut = Convert.ToDateTime( "12-01-2018") }
            };
		}
	}
}