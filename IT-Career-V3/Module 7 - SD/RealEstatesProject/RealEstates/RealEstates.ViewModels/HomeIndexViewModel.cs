﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.ViewModels
{
    public class HomeIndexViewModel
    {
        public TopPropertiesViwModel TopExpesnive { get; set; }
        public TopPropertiesViwModel TopCheapest { get; set; }
        public TopPropertiesViwModel TopNewest { get; set; }
        public TopPropertiesViwModel LastAdded { get; set; }
    }
}
