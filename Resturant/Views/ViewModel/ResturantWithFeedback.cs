using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturant.Views.ViewModel
{
    public class ResturantWithFeedback
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Place { get; set; }
            public int Rate { get; set; }
            public string Menu { get; set; }
            public string ResturantPhoto { get; set; }
            public string Descrtption { get; set; }
            public string Comment { get; set; }

    }
}