using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcProj.Models
{
    public class animalModel
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "first name")]
        public string first_name { get; set; }

        [Display(Name = "last name")]
        public string last_name { get; set; }

        [Display(Name = "message")]
        public string message { get; set; }
    }
}
