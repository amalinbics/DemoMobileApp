using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMobileApp.Model
{
    class ContactGroup : List<Contact>
    {
        public ContactGroup(string title,string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
    }
}
