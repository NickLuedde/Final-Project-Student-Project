using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAG_101.Models
{
    public class _LocalBusinessUsers1
    {
        [MetadataType(typeof(Models.ExpertAnnotations))]
        public partial class LocalBusinessUsers1
        {








        }

        public class BusinessUsersAnnotations
        {
            public string Name { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "What is Your Corporate FEIN ?")]

            public string BU_FEIN { get; set; }

            [Display(Name = "Zip Code")]
            public int? Location_Zip { get; set; }

            [Display(Name = "Phone Number")]
            [Phone]
            public string Phone_Number { get; set; }


            
            
        }




    }
}