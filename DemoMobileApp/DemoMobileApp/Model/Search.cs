﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMobileApp.Model
{
   public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
