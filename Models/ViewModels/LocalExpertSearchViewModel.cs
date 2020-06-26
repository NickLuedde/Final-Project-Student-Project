using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;
using GAG_101.Models;

   


namespace GAG_101.Models.ViewModels
{

    //This is Simply Establishing A General Search....WILL HAVE TO CREATE A DIFFERENT SEARCH BY JOB TYPE? OR CAN I INCLUDE JOB TYPE HERE AND ITERATE A DIFFERENT WAY?

    public class LocalExpertSearchViewModel
    {

        //Will Write Code Here To Order The Experts by # Ranking in Some Way? Stars? 

        [Display(Name = "Rankings")]
        public ExpertSortOrder SortOrder { get; set; }
        
        
    
        //Established Properties For The Expert
        
        public string Name { get; set; }

        [Display(Name = "Business Name")]
        public string Business_Name { get; set; }
        
        
        [Display(Name = "Zip Code")]

        public Nullable<int> Location_Zip { get; set; }

        //Established Properties For The Review
        //public int FairPrice_Rating { get; set; }
        //public int Quality_Rating { get; set; }
        //public int CompletionTime_Rating { get; set; }

        [Display(Name = "Expertise")]
        public int? Job_Type_ID { get; set; }



        //Lists of User Reviews & Their Individual Job Types
        //I Switched The Collections Class to IEnumerable....Perhaps this is better, but may need to be addressed.
       // public virtual IEnumerable<UserReviews1> UserReviews1 { get; set; }
      

       


        }

        
    
}