using System;
using System.Collections.Generic;
using System.Text;
using DemoMobileApp.Model;
namespace DemoMobileApp.Service
{
    public static class ActivityService
    {
        public static List<Activity> Get()
        {
            return new List<Activity> {
                new Activity{ Name = "Jeni", url = "http://lorempixel.com/100/100/people/1/", Description= " Jeni test" },
                new Activity{ Name = "Amal", url = "http://lorempixel.com/100/100/people/2/", Description= "Amal test" },
                new Activity{ Name = "Raj", url = "http://lorempixel.com/100/100/people/3/", Description= " Raj test" },
                new Activity{ Name = "Arockia", url = "http://lorempixel.com/100/100/people/4/", Description= "Arockia test" },
                new Activity{ Name = "Able", url = "http://lorempixel.com/100/100/people/5/", Description= "Able test" }
            };
        }
    }
}
