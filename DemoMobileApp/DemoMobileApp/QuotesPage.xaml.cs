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
    public partial class QuotesPage : ContentPage
    {
        string[] quotes = { "Quote1", "Quote2", "Quote3", "Quote4", "Quote5", "Quote6" };
        int current = 1;
        int max = 7;
        public QuotesPage()
        {
            InitializeComponent();

            lblQuote.Text = quotes[current - 1];
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (current == max)
                current = 1;
            lblQuote.Text = quotes[current - 1];
            current++;
        }
    }
}