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
    public partial class MasterDetailContactPage : MasterDetailPage
    {
        public MasterDetailContactPage()
        {
            InitializeComponent();
            lvContacts.ItemsSource = new List<Contact> {
                 new Contact{ Name = "Amal", Status="Hi, Let's talk",url="http://lorempixel.com/100/100/people/1/"},
                  new Contact{ Name = "Raj", Status="What's up",url="http://lorempixel.com/100/100/people/2/"}
            };
        }

        private void lvContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage( new  ContactDetail(contact));
            IsPresented = false;
        }
    }
}