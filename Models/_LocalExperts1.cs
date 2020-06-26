using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Expressions;

namespace GAG_101.Models
{




    [MetadataType(typeof(ExpertAnnotations))]
    public partial class LocalExperts1
    {

        public double? AverageRating {

            get
            {
                if (UserReviews1.Any())
                {

                 
                     return  UserReviews1.Average(r => r.Quality_Rating + r.CompletionTime_Rating + r.FairPrice_Rating) / 3;


                }

                else
                {


                    return null;

                }
            }






        }


        public double? QualityRating
        {
            get
            {
                if (UserReviews1.Any())
                {
                    return UserReviews1.Sum(r => r.Quality_Rating );
                }
                else
                {
                    return null;
                }
            }
        }

        public double? CompletionTimeRating
        {
            get
            {
                if (UserReviews1.Any())
                {
                    return UserReviews1.Sum(r => r.CompletionTime_Rating);
                }
                else
                {
                    return null;
                }
            }
        }

        public double? FairPriceTimeRating
        {
            get
            {
                if (UserReviews1.Any())
                {
                    return UserReviews1.Sum(r => r.FairPrice_Rating);
                }
                else
                {
                    return null;
                }
            }
        }

        
    }

    public class ExpertAnnotations
    {
        [Display(Name = "Expert ID")]
        public int LocalExpert_ID { get; set; }
        [Display(Name = "Expert User ID")]
        public string LocalExpert_UserID { get; set; }
        public string Name { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Business")]

        public string Business_Name { get; set; }

        [Display(Name = "Expertise")]
        public string Name_JobType { get; set; }

        [Display(Name = "Federal Tax ID Number")]
        public string BU_FEIN { get; set; }

        [Display(Name = "Zip")]
        public Nullable<int> Location_Zip { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone_Number { get; set; }

        [Display(Name = "User Reviews")]
        public virtual ICollection<UserReviews1> UserReviews1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [Display(Name = "Type of Expertise")]
        public virtual ICollection<JobTypes1> JobTypes1 { get; set; }
    }





}





