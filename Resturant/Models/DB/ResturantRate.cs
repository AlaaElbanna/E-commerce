using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resturant.Models.DB
{
    public class ResturantRate
    {
        public int ID { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Resturant")]
        public int RestID { get; set; }
        public Resturant Resturant { get; set; }
        public string UserId { get; set; }
        public DateTime FeedbackRate { get; set; }
    }
}