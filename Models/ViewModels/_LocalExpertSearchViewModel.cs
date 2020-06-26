using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAG_101.Models.ViewModels
{
    public class _LocalExpertSearchViewModel
    {
        [MetadataType(typeof(Models.ExpertAnnotations))]
        public partial class LocalExpertSearchViewModel
        {





        }

        public class LocalExpertSearchAnnotations
        {
            [Display(Name = "Rankings")]
            public ExpertSortOrder SortOrder { get; set; }



            //Established Properties For The Expert

            public string Name { get; set; }
            
            [Display(Name = "Business")]
            public string Business_Name { get; set; }
            
            [Display(Name = "Zip")]
            public Nullable<int> Location_Zip { get; set; }

            //Established Properties For The Review
            //public int FairPrice_Rating { get; set; }
            //public int Quality_Rating { get; set; }
            //public int CompletionTime_Rating { get; set; }

            [Display(Name = "Expertise Category")]
            public int? Job_Type_ID { get; set; }

            [Display(Name = "Expertise")]
            public string Name_JobType  { get; set; }

            [Display(Name = "Fair Pricing Score")]
            public int FairPricing { get; set; }

            [Display(Name = "Quality of Work Score")]
            public int QualityRating { get; set; }

            [Display(Name = "Timely Completion Score")]
            public int CompletionTime { get; set; }
        }










    }
}