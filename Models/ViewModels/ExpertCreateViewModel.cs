using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAG_101.Models.ViewModels
{
    public class ExpertCreateViewModel
    {
        
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Name of Your Business")]

        public string Business_Name { get; set; }

        [Display(Name = "Your Expertise")]
        public string Name_JobType { get; set; }

        [Display(Name = "Federal Tax ID #")]
        public string BU_FEIN { get; set; }

        [Display(Name = "Zip Code")]
        public Nullable<int> Location_Zip { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone_Number { get; set; }

       
        [Display(Name = "Types of Skill")]
        public IEnumerable<int> JobTypes1 { get; set; }



    }
}