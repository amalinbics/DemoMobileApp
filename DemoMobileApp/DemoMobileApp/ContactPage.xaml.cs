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
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();

            lvContacts.ItemsSource = new List<Contact> {
                 new Contact{ Name = "Amal", Status="Hi, Let's talk",url="http://lorempixel.com/100/100/people/1/"},
                  new Contact{ Name = "Raj", Status="What's up",url="http://lorempixel.com/100/100/people/2/"}
            };
        }

        private async void lvContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            if (contact == null)
                return;
            await Navigation.PushAsync(new ContactDetail(contact));
            lvContacts.SelectedItem = null;
        }
    }
}