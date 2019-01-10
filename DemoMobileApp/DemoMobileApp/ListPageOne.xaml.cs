using DemoMobileApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPageOne : ContentPage
    {
        ObservableCollection<ContactGroup> _contacts;
        public ListPageOne()
        {
            InitializeComponent();

            //lvContacts.ItemsSource = new List<Contact>
            //{
            //    new Contact{ Name = "Amal", Status="Hi, Let's talk",url="http://lorempixel.com/100/100/people/1/"},
            //     new Contact{ Name = "Raj", Status="What's up",url="http://lorempixel.com/100/100/people/2/"}
            //};

            _contacts = GetContacts();

            lvContacts.ItemsSource = _contacts;



        }

        private void lvContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");

        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var contact = item.CommandParameter as Contact;

            DisplayAlert("Calling", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var contact = item.CommandParameter as Contact;

            ContactGroup contactGroup = _contacts.Single(c => c.Title == contact.Name.Substring(0, 1));

            _contacts.Remove(contactGroup);


        }

        private void lvContacts_Refreshing(object sender, EventArgs e)
        {
            lvContacts.ItemsSource = GetContacts();
            lvContacts.EndRefresh();
        }

        private ObservableCollection<ContactGroup> GetContacts(string searchText = null )
        {
           ObservableCollection<ContactGroup> contacts =  new ObservableCollection<ContactGroup>
            {
                new ContactGroup("A","A")
                {
                     new Contact{ Name = "Amal", Status="Hi, Let's talk",url="http://lorempixel.com/100/100/people/1/"}
                },
                new ContactGroup("R","R")
                {
                    new Contact{ Name = "Raj", Status="What's up",url="http://lorempixel.com/100/100/people/2/"}
                }
            };

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                ObservableCollection<ContactGroup> filteredContacts = contacts.Where(c => c.Title == "A") as ObservableCollection<ContactGroup>;
                contacts = filteredContacts ;
            }
            return contacts;
        }

        private void sBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvContacts.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}