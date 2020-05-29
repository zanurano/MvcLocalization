using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcLocalization.LocalResource;

namespace MvcLocalization.Models
{
    public class Register
    {
        [Display(Name = "FullName", ResourceType = typeof(Resource))]
        public string FullName { get; set; }

        [Display(Name = "Address", ResourceType =typeof(Resource))]
        public string Address { get; set; }

        [Display(Name = "City", ResourceType = typeof(Resource))]
        public string City { get; set; }

        [Display(Name = "Country", ResourceType = typeof(Resource))]
        public string Country { get; set; }
    }
}